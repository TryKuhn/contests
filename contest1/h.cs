using System;

namespace Solve
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                if (s.Length != 1 || !('a' <= s[0] && s[0] <= 'z'))
                {
                    throw new FormatException();
                }
                Console.WriteLine((int)(Char.ToLower(s[0]) - 'a') + 1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
            }

            return 0;
        }
    }
}
