using System;

class FallDown
{
    static void Main()
    {
        byte number = 0;
        byte[] verticalLines = new byte[8];
        byte[] numberOfOnes = new byte[8];

        for (byte i = 0; i < 8; i++)
        {
            number = byte.Parse(Console.ReadLine());

            for (byte j = 0; j < 8; j++)
            {
                verticalLines[j] += (byte)(((number & (1 << (8 - j - 1))) >> (8 - j - 1)) << i);
                numberOfOnes[j] += (byte)((number & (1 << (8 - j - 1))) >> (8 - j - 1));
            }
        }

        for (byte i = 0; i < 8; i++)
        {
            verticalLines[i] = 0;

            for (byte j = 0; j < numberOfOnes[i]; j++)
            {
                verticalLines[i] += (byte)(1 << (8 - j - 1));
            }
        }

        for (byte i = 0; i < 8; i++)
        {
            number = 0;

            for (byte j = 0; j < 8; j++)
            {
                number += (byte)(((verticalLines[j] & (1 << i)) >> i) << (8 - j - 1));
            }

            Console.WriteLine(number);
        }
    }
}