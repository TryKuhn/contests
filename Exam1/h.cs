using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solve
{
    class Solver
    {
        public static void Main(string[] args)
        {
            string[] s = File.ReadAllLines("input.txt");

            int getStrings = s.Length, getWords = 0, getSymbols = 0;

            for (int i = 0; i < s.Length; i++)
            {
                getSymbols += s[i].Length;
                getWords += s[i].Split(new char[]  {' ', '.', ',', '?', '!', ':', ';'}, StringSplitOptions.RemoveEmptyEntries).Length;
            }
            Console.WriteLine(getStrings);
            Console.WriteLine(getWords);
            Console.WriteLine(getSymbols);
        }
    }
}
