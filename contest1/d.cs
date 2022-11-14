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
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a > b ? "First" : a == b ? "Equal" : "Second");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
            }

            return 0;
        }
    }
}
