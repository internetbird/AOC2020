using AOC2020.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOC2020.PuzzleSolvers
{
    public class Day1PuzzleSolver : IPuzzleSolver
    {
        public string SolvePuzzlePart1()
        {
            string[] inputLines = InputFilesHelper.GetInputFileLines("day1.txt");
            int[] expanses = inputLines.Select(int.Parse).ToArray();

            for (int i = 0; i < expanses.Length; i++)
            {
                int expanse1 = expanses[i];

                for (int j = 0; j < expanses.Length; j++)
                {
                    if (j == i) continue;

                    int expanse2 = expanses[j];

                    if (expanse1 + expanse2 == 2020)
                    {
                        return (expanse1 * expanse2).ToString();
                    }
                }
            }
            return String.Empty;
        }

        public string SolvePuzzlePart2()
        {
            string[] inputLines = InputFilesHelper.GetInputFileLines("day1.txt");
            int[] expanses = inputLines.Select(int.Parse).ToArray();

            for (int i = 0; i < expanses.Length; i++)
            {
                int expanse1 = expanses[i];

                for (int j = 0; j < expanses.Length; j++)
                {
                    if (j == i) continue;

                    int expanse2 = expanses[j];

                    for (int k = 0; k < expanses.Length; k++)
                    {
                        if (k == i || k == j) continue;

                        int expanse3 = expanses[k];

                        if (expanse1 + expanse2 + expanse3 == 2020)
                        {
                            return (expanse1 * expanse2 * expanse3).ToString();
                        }
                    }
                }
            }
            return String.Empty;
        }
    }
}
