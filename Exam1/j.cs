using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
 
namespace Solve
{
    class Solver
    {
 
        public static int Calc(string s)
        {
            if (s[0] == '(')
            {
                s = s.Substring(1, s.Length - 2);
            }
 
            int prevl = -1;
            bool started = false;
 
            List<string> op = new List<string>();
 
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    if (started)
                    {
                        started = false;
                        op.Add(s.Substring(prevl, i - prevl));
                    }
                    op.Add(s.Substring(i, 1));
                } else
                {
                    if(!started)
                    {
                        started = true;
                        prevl = i;
                    }
                }
            }
            if (started)
            {
                started = false;
                op.Add(s.Substring(prevl, s.Length - prevl));
            }
 
            for (int i = 0; i + 1 < op.Count; i++)
            {
                if (op[i] == "*" || op[i] == "/")
                {
                    int l = Int32.Parse(op[i - 1]), r = Int32.Parse(op[i + 1]);
                    if (op[i] == "*")
                    {
                        l *= r;
                    } else
                    {
                        l /= r;
                    }
                    op.RemoveRange(i - 1, i + 1);
                    op.Insert(i - 1, Convert.ToString(l));
 
                }
            }
 
            for (int i = 0; i + 1 < op.Count; i++)
            {
                if (op[i] == "+" || op[i] == "-")
                {
                    int l = Int32.Parse(op[i - 1]), r = Int32.Parse(op[i + 1]);
                    if (op[i] == "+")
                    {
                        l += r;
                    }
                    else
                    {
                        l -= r;
                    }
                    op.RemoveRange(i - 1, i + 1);
                    op.Insert(i - 1, Convert.ToString(l));
 
                }
            }
 
            s = op[0];
 
            return Int32.Parse(s);
        }
 
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while (true)
            {
                int posl = -1, posr = -1;
 
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        posl = i;
                    }
                    if (s[i] == ')')
                    {
                        posr = i;
                        break;
                    }
                }
 
                if (posl == -1)
                {
                    break;
                }
 
                int cur = Calc(s.Substring(posl, posr - posl + 1));
 
                s = s.Substring(0, posl) + Convert.ToString(cur) + s.Substring(posr + 1, s.Length - 1 - posr);
            }
 
            int ans = Calc(s);
 
            Console.WriteLine(ans);
        }
    }
}
