using System;

class ExcelColumns
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        ulong columnIndex = 0;
        
        for (byte i = 0; i < n; i++)
        {
            char input = char.Parse(Console.ReadLine());

            columnIndex += (ulong)((input - 64) * (Math.Pow(26, n - i - 1)));
        }
        Console.WriteLine(columnIndex);
    }
}