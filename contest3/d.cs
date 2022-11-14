using System;

public partial class Program
{
    private static Boolean Validate(string input, out int num)
    {
        bool ok = Int32.TryParse(input, out num);
        return ok && num >= 0;
    }

    private static int RecurrentFunction(int n)
    {
        int pw = 3;
        for (int i = 1; i <= n; i++)
        {
            pw = (pw + 1) * 2;
        }
        return pw;
    }
}
