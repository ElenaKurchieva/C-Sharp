using System;

class UKFlag
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string insideDotString = "";
        string outsideDotString = "";
        string middleString = "";

        byte half = (byte)(n / 2);

        for (byte i = 0; i < half; i++)
        {
            outsideDotString = new string('.', i);
            insideDotString = new string('.', (n - 3 - 2 * i) / 2);
            Console.WriteLine(outsideDotString + "\\" + insideDotString + "|" + insideDotString + "/" + outsideDotString);
        }

        middleString = new string('-', half);

        Console.WriteLine(middleString + "*" + middleString);

        for (byte i = 0; i < half; i++)
        {
            outsideDotString = new string('.', (n - 3 - 2 * i) / 2);
            insideDotString = new string('.', i);
            Console.WriteLine(outsideDotString + "/" + insideDotString + "|" + insideDotString + "\\" + outsideDotString);
        }
    }
}