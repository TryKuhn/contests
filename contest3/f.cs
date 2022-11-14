using System;
using System.Collections.Generic;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        int prev = 0;
        List<Tuple<int, int>> l = new List<Tuple<int, int>>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
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

    private static int GetNumberOfEqualElements(int[] first, int[] second)
    {
        Dictionary<int, int> cnt = new Dictionary<int, int>();
        for (int i = 0; i < second.Length; i++)
        {
            if (!cnt.ContainsKey(second[i]))
            {
                cnt.Add(second[i], 0);
            }
            cnt[second[i]]++;
        }

        int ans = 0;
        for (int i = 0; i < first.Length; i++)
        {
            if (cnt.ContainsKey(first[i]))
            {
                ans++;
            }
        }

        return ans;
    }
}
