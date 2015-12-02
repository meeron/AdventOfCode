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
            Console.WriteLine("----------------Advent of Code------------");
            Console.WriteLine("---------------------Day 1----------------");
            Console.WriteLine("Puzzle 1 output: {0}", day1.SovlePuzzle1());
            Console.WriteLine("Puzzle 2 output: {0}", day1.SolvePuzzle2());

            Console.ReadLine();
        }
    }
}
