using System;

namespace Solve
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                if (a < 0 || b < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine(Math.Sqrt(a * a + b * b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
            }

            return 0;
        }
    }
}
