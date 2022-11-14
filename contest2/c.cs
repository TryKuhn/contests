using System;
using System.Globalization;
using System.Net.Mime;

namespace Solve
{
    internal class Program
    {
        public static int ReadInt()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    Console.WriteLine("Incorrect input");
                    Environment.Exit(0);
                }
            }
            return Convert.ToInt32(s);
        }
        
        public static int Main(string[] args)
        {
            
            int a = ReadInt();
            Console.WriteLine(a % 10);
            return 0;
        }
    }
}
