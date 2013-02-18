using System;

class AstrologicalDigits
{
    static void Main()
    {
        string inputN = Console.ReadLine();
        
        ushort astroSum;

        do
        {
            astroSum = 0;

            foreach (char ch in inputN)
            {
                if (ch != '.' && ch != '-')
                {
                    astroSum += (ushort)(ch - '0');
                }
            }
            inputN = astroSum.ToString();

        } while (astroSum > 9);

        Console.WriteLine(astroSum);
    }
}