using System;

class AnacciAlternative
{
    static void Main()
    {
        char[] codes = new char[27];

        for (byte i = 1; i < codes.Length; i++)
        {
            codes[i] = (char)(64 + i);
        }

        int anacciMinusTwo = int.Parse(Console.ReadLine());
        int anacciMinusOne = int.Parse(Console.ReadLine());
        byte lines = byte.Parse(Console.ReadLine());

        int anacci = 0;
        
        Console.WriteLine((char)(anacciMinusTwo));
        
        if (lines > 1)
        {
            for (byte i = 0; i < lines - 1; i++)
            {
                anacci = (anacciMinusOne + anacciMinusTwo) % 26
            }
        }
    }
}