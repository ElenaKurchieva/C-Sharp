using System;

class Pillars
{
    static void Main()
    {
        byte[] sums = {0, 0, 0, 0, 0, 0, 0, 0};
        byte n;
        byte leftSum = 0;
        byte rightSum = 0;
        byte pillar = 0;
        bool pillarExists = false;

        for (byte i = 0; i < 8; i++)
        {
            n = byte.Parse(Console.ReadLine());

            for (byte j = 0; j < 8; j++)
            {
                sums[j] += (byte)((n & (1 << (8 - j - 1))) >> (8 - j - 1));                
            }
        }

        for (byte i = 0; i < 8; i++)
        {
            leftSum = 0;

            for (byte j = 0; j < i; j++)
            {
                leftSum += sums[j];
            }

            rightSum = 0;

            for (byte k = (byte)(i + 1); k < 8; k++)
            {
                rightSum += sums[k];
            }

            if (leftSum == rightSum)
            {
                pillar = (byte)(8 - i - 1);
                pillarExists = true;
                break;
            }
        }

        if (pillarExists)
        {
            Console.WriteLine(pillar);
            Console.WriteLine(leftSum);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}