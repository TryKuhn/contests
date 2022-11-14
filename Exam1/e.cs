using System;

namespace Solve
{
    class Solver
    {

        public static void Main(string[] args)
        {
            bool ok = Int32.TryParse(Console.ReadLine(), out int n);
            if (!ok || n <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                ok &= Int32.TryParse(Console.ReadLine(), out a[i]);
            }
            if (!ok)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            double average = 0;
            for (int i = 0; i < n; i++)
            {
                average += a[i];
            }
            average /= n;

            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < average)
                {
                    cnt += a[i];
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
