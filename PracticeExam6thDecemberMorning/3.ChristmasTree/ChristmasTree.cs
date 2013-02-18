using System;

class ChristmasTree
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string dotString = "";
        string starString = "";
        string treeTrunk = new string('.', n - 2) + "*" + new string('.', n - 2);

        for (byte i = 1; i <= 2 * n - 3; i += 2)
        {
            dotString = new string('.', ((2 * n - 3) - i) / 2);
            starString = new string('*', i);
            Console.WriteLine(dotString + starString + dotString);
        }

        Console.WriteLine(treeTrunk);
    }
}