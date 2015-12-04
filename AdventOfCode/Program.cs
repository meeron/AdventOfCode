using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1 = new Day1();
            var day2 = new Day2();

            Console.WriteLine("----------------Advent of Code------------");
            Console.WriteLine("---------------------Day 1----------------");
            Console.WriteLine("Puzzle 1 output: {0}", day1.SolvePuzzle1());
            Console.WriteLine("Puzzle 2 output: {0}", day1.SolvePuzzle2());
            Console.WriteLine("---------------------Day 2----------------");
            Console.WriteLine("Puzzle 1 output: {0}", day2.SolvePuzzle1());
            Console.WriteLine("Puzzle 2 output: {0}", day2.SolvePuzzle2());

            Console.ReadLine();
        }
    }
}
