using System;

namespace Solve
{
    class Solver
    {
        public static void Main(string[] args)
        {
            bool ok = Int32.TryParse(Console.ReadLine(), out Int32 a);
            ok &= Int32.TryParse(Console.ReadLine(), out Int32 b);
            ok &= Int32.TryParse(Console.ReadLine(), out Int32 c);
            if (!ok || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("Incorrect input");
            } else
            {
                Console.WriteLine(a + b + c);
            }
        }
    }
}
