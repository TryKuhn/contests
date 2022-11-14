using System;

public partial class Program
{
    private static int[][] GetBellTriangle(uint rowCount)
    {
        int[][] ans = new int[rowCount][];
        ans[0] = new[] { 1 };
        for (int i = 1; i < rowCount; i++)
        {
            ans[i] = new int[i + 1];
            ans[i][0] = ans[i - 1][i - 1];
            for (int j = 1; j <= i; j++)
            {
                ans[i][j] = ans[i - 1][j - 1] + ans[i][j - 1];
            }
        }

        return ans;
    }

    private static void PrintJaggedArray(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.Write('\n');
        }
    }
}
