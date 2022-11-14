using System;

namespace Solve
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                string s = Convert.ToString(a);
                if (s.Length != 4 || a < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine((s[0] == s[3] && s[1] == s[2]) ? "True" : "False");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
            }

            return 0;
        }
    }
}
