using System;

public partial class Program
{
    private static int GetCountGreaterThanValue(int[] array, double average)
    {
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
            {
                cnt++;
            }
        }

        return cnt;
    }

    private static double GetAverage(int[] array)
    {
        double ans = 0;
        for (int i = 0; i < array.Length; i++)
        {
            ans += array[i];
        }

        ans /= array.Length;
        return ans;
    }
    
    private static bool ValidateNumber(out int n)
    {
        bool ok = Int32.TryParse(Console.ReadLine(), out n);
        return ok && n >= 0;
    }
    
    private static bool ReadNumbers(int n, out int[] array)
    {
        array = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (!ValidateNumber(out array[i]))
            {
                return false;
            }
        }

        return true;
    }
}
