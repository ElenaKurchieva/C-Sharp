using System;

class DancingBits
{
    static void Main()
    {
        ushort k = ushort.Parse(Console.ReadLine());
        ushort n = ushort.Parse(Console.ReadLine());

        string concatenatedBits = "";

        for (ushort i = 0; i < n; i++)
        {
            concatenatedBits += Convert.ToString(uint.Parse(Console.ReadLine()), 2);
        }

        char previousChar = '.';
        ushort counter = 0;
        ushort result = 0;

        for (ushort i = 0; i < concatenatedBits.Length; i++)
        {
            if (concatenatedBits[i] == previousChar)
            {
                counter++;
            }
            else if (counter == k)
            {
                result++;
                counter = 1;
            }
            else
            {
                counter = 1;
            }

            previousChar = concatenatedBits[i];
        }

        Console.WriteLine("{0}", counter == k ? result + 1 : result);
    }
}