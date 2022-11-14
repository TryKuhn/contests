using System;
using System.Collections.Generic;

public static class Program
{

    public static int[] ConvertToArray(string input)
    {
        int prev = 0;
        List<Tuple<int, int>> l = new List<Tuple<int, int>>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ',')
            {
                Tuple<int, int> cur = new Tuple<int, int>(prev, i - prev);
                prev = i + 1;
                l.Add(cur);
            }
        }
        l.Add(new Tuple<int, int>(prev, input.Length - prev));
        
        int[] ans = new int[l.Count];
        for (int i = 0; i < l.Count; i++)
        {
            ans[i] = Int32.Parse(input.Substring(l[i].Item1, l[i].Item2));
        }

        return ans;
    }

    public static void WriteArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
        }
    }

    public static void ShiftLeft(ref int[] a)
    {
        int[] cur = new int[a.Length];
        cur[a.Length - 1] = a[0];
        for (int i = 0; i + 1 < a.Length; i++)
        {
            cur[i] = a[i + 1];
        }
        a = cur;
    }

    public static void WriteMatrix(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            WriteArray(a);
            ShiftLeft(ref a);
            Console.Write('\n');
        }
    }
    
    public static void Main(string[] args)
    {
        int[] a = ConvertToArray(Console.ReadLine());
        WriteMatrix(a);
    }
}
