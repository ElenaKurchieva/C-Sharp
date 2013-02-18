using System;

class ForestRoad
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string dotString = new string('.', (n - 1));
        string dotStringIncreasing;
        string dotStringDecreasing;
        string starString = "*";

        for (byte i = 0; i < n; i++)
        {
            dotStringIncreasing = new string('.', i);
            dotStringDecreasing = new string('.', n - i - 1);

            Console.WriteLine("{0}{1}{2}", dotStringIncreasing, starString, dotStringDecreasing);
        }

        for (byte i = 1; i < n; i++)
        {
            dotStringIncreasing = new string('.', i);
            dotStringDecreasing = new string('.', n - i - 1);

            Console.WriteLine("{0}{1}{2}", dotStringDecreasing, starString, dotStringIncreasing);
        }
    }
}