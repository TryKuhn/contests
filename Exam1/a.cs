using System;

namespace Solve
{
    class Solver
    {
        public static void Main(string[] args)
        {
            bool ok = Int16.TryParse(Console.ReadLine(), out Int16 a);
            ok &= Int16.TryParse(Console.ReadLine(), out Int16 b);
            if (!ok)
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                Console.WriteLine(a ^ b);
            }
        }
    }
}
