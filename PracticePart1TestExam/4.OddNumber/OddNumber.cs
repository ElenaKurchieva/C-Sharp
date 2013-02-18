using System;
using System.Collections.Generic;

class OddNumber
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        long number = 0;
        long oddNumber = 0;

        for (uint i = 0; i < n; i++)
        {
            number = long.Parse(Console.ReadLine());

            oddNumber ^= number;
        }
        Console.WriteLine(oddNumber);
    }
}