using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    static long NN => long.Parse(ReadLine());
    static long[] NList => ReadLine().Split().Select(long.Parse).ToArray();

    private static void Main(string[] args)
    {

        long[] a = NList;
        long n = a.Length;
        
        long[] dp1 = new long[n];
        long[] dp2 = new long[n];

        if (n == 1)
        {
            WriteLine(a[0]);
            return;
        }

        if (n == 2)
        {
            WriteLine(Math.Max(a[0], a[1]));
            return;
        }

        if (n == 3)
        {
            WriteLine(Math.Max(Math.Max(a[0], a[1]), a[2]));
            return;
        }
        
        dp1[0] = a[0];
        dp1[1] = Math.Max(a[1], a[0]);
        for (int i = 2; i + 1 < n; i++)
        {
            dp1[i] = Math.Max(dp1[i - 1], dp1[i - 2] + a[i]);
        }

        dp2[1] = a[1];
        dp2[2] = Math.Max(a[1], a[2]);
        for (int i = 3; i < n; i++)
        {
            dp2[i] = Math.Max(dp2[i - 1], dp2[i - 2] + a[i]);
        }
        WriteLine(Math.Max(dp1[n - 2], dp2[n - 1]));
    }
}
