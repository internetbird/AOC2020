using AOC2020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOC2020.Parsers
{
    public class PasswordRuleParser
    {
        public (string password, PasswordRule rule) ParseLine(string line)
        {
            string[] lineParts = line.Split(':');

            string passsword = lineParts[1].Trim();
            string[] ruleParts = lineParts[0].Split(' ');

            char character = ruleParts[1][0];
            string[] limitParts = ruleParts[0].Split('-');

            int lowLimit = int.Parse(limitParts[0]);
            int highLimit = int.Parse(limitParts[1]);

            var rule = new PasswordRule(character, lowLimit, highLimit);

            return (passsword, rule);

        }
    }
}
