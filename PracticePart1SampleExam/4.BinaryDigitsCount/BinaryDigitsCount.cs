using System;

class BinaryDigitsCount
{
    static void Main()
    {
        byte binaryDigit = byte.Parse(Console.ReadLine());
        ushort n = ushort.Parse(Console.ReadLine());
        uint input = 0;
        byte length = 0;
        byte count = 0;

        for (ushort i = 0; i < n; i++)
        {
            length = 0;
            count = 0;

            input = uint.Parse(Console.ReadLine());

            length = (byte)Convert.ToString(input, 2).Length;

            for (byte j = 0; j < length; j++)
            {
                count += (byte)(1 - (((input & (1 << j)) >> j) ^ binaryDigit));
            }
            Console.WriteLine(count);
        }
    }
}