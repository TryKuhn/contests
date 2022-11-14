using System;

public partial class Program
{
    private static void GetLetterDigitCount(string line, out int digitCount, out int letterCount)
    {
        digitCount = 0;
        letterCount = 0;
        for (int i = 0; i < line.Length; i++)
        {
            if (Char.IsDigit(line[i]))
            {
                digitCount++;
            }

            if (Char.IsLetter(line[i]))
            {
                letterCount++;
            }
        }
    }
}
