using System;

partial class Program
{
    private static string Encrypt(string input)
    {
        string b = new string("");
        int[] cnt = new int[100001];
        for (int i = 0; i < input.Length; i++)
        {
            cnt[input[i]]++;
        }

        int mn = -1, mx = -1;

        for (int i = 0; i <= 100000; i++)
        {
            if (cnt[i] != 0 && (mn == -1 || cnt[mn] > cnt[i]))
            {
                mn = i;
            }
            if (cnt[i] != 0 && (mx == -1 || cnt[mx] < cnt[i]))
            {
                mx = i;
            }
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (cnt[input[i]] == cnt[mx])
            {
                b = b + (char)mn;
            } 
            else if (cnt[input[i]] == cnt[mn])
            {
                b = b + (char)mx;
            } else
            {
                b = b + input[i];
            }
        }

        return b;
    }
}
