using System;

namespace Solve
{
    internal class Program
    {
        private const double eps = 1e-9;

        public static int Intersect(double x, double y, double Rs)
        {
            double k = Rs - x * x;
            if (k < 0)
            {
                return 0;
            }

            k = Math.Sqrt(k);
            if (k == 0)
            {
                return y == k ? 1 : 0;
            }

            double y1 = -k, y2 = k;
            if (y1 == y || y2 == y)
            {
                return 1;
            }

            if (y1 < y && y < y2)
            {
                return 2;
            }

            return 0;
        }
        
        public static int Main(string[] args)
        {
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (Intersect(x, y, 1) != 2 && Intersect(x, y, 2) != 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
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
