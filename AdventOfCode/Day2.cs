using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day2
    {
        private readonly string[] _input;

        public Day2()
        {
            _input = File.ReadAllLines(@"c:\Users\miron\Documents\Visual Studio 2013\Projects\AdventOfCode\inputs\Day2-input.txt");
        }

        public int SolvePuzzle1()
        {
            return this._input.Select(x => Dimension.Parse(x)).Sum(x => x.Area);
        }

        public int SolvePuzzle2()
        {
            throw new NotImplementedException();
        }
    }

    struct Dimension
    {
        public int L;
        public int W;
        public int H;

        //in format: LxWxH 
        public static Dimension Parse(string input)
        {
            string[] arr = input.Split('x');
            if (arr.Length != 3)
                throw new ArgumentException("Invalid input for dimension.");

            var result = new Dimension();
            int.TryParse(arr[0], out result.L);
            int.TryParse(arr[1], out result.W);
            int.TryParse(arr[2], out result.H);         

            return result;
        }

        private int[] Sides { get { return new int[] { L * W, W * H, H * L }; } }

        public int Area
        {
            get
            {
                return this.Sides.Select(x => x * 2).Sum() + this.Sides.Min();
            }
        }

        public int Volume { get { return L * W * H; } }

        //public int Ribbon
        //{
        //    get
        //    {

        //    }
        //}
    }
}
