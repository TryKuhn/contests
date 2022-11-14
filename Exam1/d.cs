using System;

namespace Solve
{
    class Solver
    {

        public static double BinPow(double a, int pw)
        {
            if (pw == 0)
            {
                return 1;
            }
            if ((pw & 1) == 1)
            {
                return BinPow(a, pw - 1) * a;
            }
            double b = BinPow(a, pw >> 1);
            return b * b;
        }

        public static void Main(string[] args)
        {
            bool ok = Double.TryParse(Console.ReadLine(), out double n);
            ok &= Int32.TryParse(Console.ReadLine(), out int k);
            if (!ok || k < 0)
            {
                Console.WriteLine("Incorrect input");
            } else
            {
                Console.WriteLine(BinPow(n, k));
            }
        }
    }
}
