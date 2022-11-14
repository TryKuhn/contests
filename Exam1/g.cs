using System;
using System.IO;

namespace Solve
{
    class Solver
    {
        public static void Main(string[] Args)
        {
            string[] cur = File.ReadAllLines("rick.in");

            int cnt = 0;

            for (int i = 0; i < cur[0].Length; i++)
            {
                if (cur[0][i] >= 'A' && cur[0][i] <= 'Z')
                {
                    cnt++;
                }
            }
            cur[0] = Convert.ToString(cnt);

            File.WriteAllLines("morty.out", cur);
        }
    }
}
