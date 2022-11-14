using System;
using System.Collections.Generic;
using System.Linq;

partial class Program
{
    private static int Count(int[] arr, int k)
    {
        List<int> a = new List<int>();

        for (int i = 0; i < arr.Length; i++)
            a.Add(arr[i]);

        Dictionary<int, int> cnt = new Dictionary<int, int>();
        for (int i = 0; i < a.Count; i++)
        {
            if (!cnt.ContainsKey(a[i]))
            {
                cnt.Add(a[i], 0);
            }
            cnt[a[i]]++;
        }

        int ans = 0;

        for (int i = 0; i < cnt.Count; i++)
        {
        Tuple<int, int> cur = new Tuple<int, int>(cnt.ElementAt(i).Key, cnt.ElementAt(i).Value);
        if (cnt.ContainsKey(k - cur.Item1))
        {
        if (cur.Item1 * 2 == k)
        {
        ans += cur.Item2 * (cur.Item2 - 1);
        }
        else
        {
        ans += cur.Item2 * cnt[k - cur.Item1];
        }
        }
        }
        return ans / 2;
    }
}
