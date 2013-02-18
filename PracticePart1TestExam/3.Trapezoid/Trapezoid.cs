using System;

class Trapezoid
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string dotString = new string('.', n);
        string dotStringDecreasing;
        string dotStringIncreasing;
        string starString = new string('*', n);

        Console.WriteLine(dotString + starString);

        for (byte i = 0; i < n - 1; i++)
		{
            dotStringDecreasing = new string('.', n - 1 - i);
            starString = "*";
            dotStringIncreasing = new string('.', n - 1 + i);
            Console.WriteLine("{0}{1}{2}{1}", dotStringDecreasing, starString, dotStringIncreasing, starString);
		}

        starString = new string('*', 2 * n);

        Console.WriteLine(starString);
    }
}