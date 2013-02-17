using System;

class TelerikLogo
{
    static void Main()
    {
        byte x = byte.Parse(Console.ReadLine());

        string dotString = "";
        string insideDotString = "";
        string extraDotString = "";
        sbyte dotLength = (sbyte)(x / 2);
        byte extraDotLength = 1;

        dotString = new string('.', dotLength);
        insideDotString = new string('.', ((3 * x - 2) - 2 - dotLength * 2));

        Console.WriteLine(dotString + "*" + insideDotString + "*" + dotString);

        do
        {
            dotLength--;
            dotString = new string('.', dotLength);
            extraDotString = new string('.', extraDotLength);
            insideDotString = new string('.', ((3 * x - 2) - 4 - dotLength * 2 - extraDotLength * 2));

            Console.WriteLine(dotString + "*" + extraDotString + "*" + insideDotString + "*" + extraDotString + "*" + dotString);
            extraDotLength += 2;
        } while (dotLength > 0);

        for (byte i = 0; i < (x - 2 - x / 2); i++)
        {
            extraDotString = new string('.', extraDotLength);
            insideDotString = new string('.', ((3 * x - 2) - 2 - extraDotLength * 2));

            Console.WriteLine(extraDotString + "*" + insideDotString + "*" + extraDotString);
            extraDotLength += 1;
        }

        dotString = new string('.', (3 * (x - 1)) / 2);

        Console.WriteLine(dotString + "*" + dotString);

        dotLength = 1;
        for (byte i = 0; i < x - 1; i++)
        {
            insideDotString = new string('.', dotLength);

            dotString = new string('.', ((3 * x - 2) - 2 - dotLength) / 2);

            Console.WriteLine(dotString + "*" + insideDotString + "*" + dotString);

            dotLength += 2;
        }

        dotLength -= 2;

        for (byte i = 0; i < x - 2; i++)
        {
            dotLength -= 2;
            insideDotString = new string('.', dotLength);
            dotString = new string('.', ((3 * x - 2) - 2 - dotLength) / 2);

            Console.WriteLine(dotString + "*" + insideDotString + "*" + dotString);
        }
            
        dotString = new string('.', (3 * (x - 1)) / 2);

        Console.WriteLine(dotString + "*" + dotString);
    }
}