using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public partial class Program
{
    private static double GetMin(double[] array)
    {
        double ans = Double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            ans = Math.Min(array[i], ans);
        }

        return ans;
    }

    private static double GetAverage(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum / array.Length;
    }

    
    
    private static double GetMedian(double[] array)
    {
        List<double> cur = new List<double>();
        for (int i = 0; i < array.Length; i++)
            cur.Add(array[i]);
        cur.Sort();
        if (cur.Count % 2 == 1)
            return cur[cur.Count / 2];
        return (cur[cur.Count / 2] + cur[cur.Count / 2 - 1]) / 2;
    }
    
    private static double[] ReadNumbers(string line)
    {
        int prev = 0;
        List<Tuple<int, int>> l = new List<Tuple<int, int>>();
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == ' ')
            {
                Tuple<int, int> cur = new Tuple<int, int>(prev, i - prev);
                prev = i + 1;
                l.Add(cur);
            }
        }
        l.Add(new Tuple<int, int>(prev, line.Length - prev));

        double[] ans = new double[l.Count];
        for (int i = 0; i < l.Count; i++)
        {
            ans[i] = Double.Parse(line.Substring(l[i].Item1, l[i].Item2));
        }

        return ans;
    }
    
}
