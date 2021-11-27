using AOC2020.Models;
using AOC2020.Parsers;
using AOC2020.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AOC2020.PuzzleSolvers
{
    public class Day2PuzzleSolver : IPuzzleSolver
    {
        public string SolvePuzzlePart1()
        {
            string[] inputLines = InputFilesHelper.GetInputFileLines("day2.txt");

            int numOfValidPasswords = 0;
            var parser = new PasswordRuleParser();

            foreach (string line in inputLines)
            {
               (string password, PasswordRule rule)  =  parser.ParseLine(line);
                if (IsValidPassword(password, rule))
                {
                   numOfValidPasswords++;
                }
            }
            return numOfValidPasswords.ToString();
        }

        private bool IsValidPassword(string password, PasswordRule rule)
        {
            var regex = new Regex(rule.Character.ToString());

            int numOfMatches = regex.Matches(password).Count;

            return numOfMatches >= rule.LowLimit && numOfMatches <= rule.HighLimit;
        }

        public string SolvePuzzlePart2()
        {
            string[] inputLines = InputFilesHelper.GetInputFileLines("day2.txt");

            int numOfValidPasswords = 0;
            var parser = new PasswordRuleParser();

            foreach (string line in inputLines)
            {
                (string password, PasswordRule rule) = parser.ParseLine(line);
                if (IsValidPasswordByPosition(password, rule))
                {
                    numOfValidPasswords++;
                }
            }
            return numOfValidPasswords.ToString();
        }

        private bool IsValidPasswordByPosition(string password, PasswordRule rule)
        {
            return (password[rule.LowLimit - 1] == rule.Character
                 || password[rule.HighLimit - 1] == rule.Character)
                 && password[rule.LowLimit - 1] != password[rule.HighLimit - 1];    
        }
    }
}
