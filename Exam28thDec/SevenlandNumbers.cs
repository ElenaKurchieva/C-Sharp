using System;

class SevenlandNumbers
{
    static void Main()
    {
        ushort[] numbers = new ushort[344];
        ushort count = 0;
        for (ushort i = 0; i < 1001; i++)
        {
            if (i % 10 == 7 || i % 10 == 8 || i % 10 == 9 ||
                i / 10 % 10 == 7 || i / 10 % 10 == 8 || i / 10 % 10 == 9 ||
                i / 100 % 10 == 7 || i / 100 % 10 == 8 || i / 100 % 10 == 9)
            {
                continue;
            }
            numbers[count] = i;
            count++;
        }

        ushort k = ushort.Parse(Console.ReadLine());
        for (ushort i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == k)
            {
                Console.WriteLine(numbers[i + 1]);
                break;
            }
        }
    }
}