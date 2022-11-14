using System;

namespace Solve
{
    class Solver
    {
        public static void Main(string[] Args)
        {
            double x = Double.Parse(Console.ReadLine());
            double ans = 0;
            double frst = x * x * x * x / 4 / 3 / 2;
            int n = 0;
            while (Math.Abs(frst) >= double.Epsilon)
            {
                ans += frst;
                frst = -frst * x * x * x / (3 * n + 5) / (3 * n + 6) / (3 * n + 7);
                n++;
            }
            Console.WriteLine(ans);
        }
    }
}
