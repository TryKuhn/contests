using System;

namespace Solve
{
    internal class Program
    {
        private const double eps = 1e-9;
        
        public static int Main(string[] args)
        {
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                if (Math.Ceiling(a) - a != a - Math.Floor(a))
                {
                    Console.WriteLine(Math.Round(a));
                }
                else
                {
                    if ((int)a % 2 != 0)
                    {
                        Console.WriteLine((int)a);
                    }
                    else
                    {
                        if (a >= 0)
                        {
                            Console.WriteLine((int)a + 1);
                        }
                        else
                        {
                            Console.WriteLine((int)a - 1);   
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
            }

            return 0;
        }
    }
}
