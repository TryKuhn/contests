using System;

namespace Solve
{
    internal class Program
    {
        private const double eps = 1e-9;

        public static int Main(string[] args)
        {
            try
            {
                bool ok = true;
                int num = 0, cnt = 0;
                string s = Console.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '.' || s[i] == ',')
                    {
                        cnt++;
                        if (cnt > 1)
                            ok = false;
                        num = s[i + 1] - '0';
                    }
                    else if (!Char.IsDigit(s[i]))
                    {
                        ok = false;
                    }

                }

                if (!ok)
                {
                    throw new FormatException();
                }
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
            }

            return 0;
        }
    }
}
