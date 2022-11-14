using System;

public partial class Program
{
    private static bool TryParseInput(string inputA, string inputB, out int a, out int b)
    {
        bool ok = Int32.TryParse(inputA, out a);
        ok &= Int32.TryParse(inputB, out b);
        ok &= a >= 0 && b >= 0;
        return ok;
    }

    private static void SwapMaxDigit(ref int a, ref int b)
    {
        string f, s;
        f = Convert.ToString(a);
        s = Convert.ToString(b);
        char mxf = '0';
        for (int i = 0; i < f.Length; i++)
        {
            if (f[i] > mxf)
            {
                mxf = f[i];
            }
        }

        char mxs = '0';
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] > mxs)
            {
                mxs = s[i];
            }
        }

        string ansf = new string("");
        string anss = new string("");
        for (int i = 0; i < f.Length; i++)
        {
            if (f[i] == mxf)
            {
                ansf += mxs;
            }
            else
            {
                ansf += f[i];
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == mxs)
            {
                anss += mxf;
            }
            else
            {
                anss += s[i];
            }
        }

        a = Int32.Parse(ansf);
        b = Int32.Parse(anss);
    }
}
