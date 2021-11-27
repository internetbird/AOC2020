﻿using AOC2020.PuzzleSolvers;
using System;

namespace AOC2020
{
    class Program
    {
        static void Main(string[] args)
        {
            IPuzzleSolver solver = new Day1PuzzleSolver();

            var solution = solver.SolvePuzzlePart2();
            Console.WriteLine($"The solution to the puzzle is: {solution}");

            Console.ReadKey();
        }
    }
}
