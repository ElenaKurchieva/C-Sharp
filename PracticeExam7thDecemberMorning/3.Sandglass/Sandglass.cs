using System;

class Sandglass
{
    static void Main()
    {
        sbyte n = sbyte.Parse(Console.ReadLine());

        string dotString;
        string starString;

        for (sbyte i = n; i > -n; i -= 2)
        {
            if (i > 0)
            {
                dotString = new string('.', (n - i) / 2);
                starString = new string('*', i);
                Console.WriteLine(dotString + starString + dotString);
            }
            else
            {
                dotString = new string('.', (n + i - 2) / 2);
                starString = new string('*', 2 - i);
                Console.WriteLine(dotString + starString + dotString);
            }
        }
    }
}