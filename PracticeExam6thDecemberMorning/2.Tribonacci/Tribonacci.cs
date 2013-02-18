using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger tribonacciMinusThree = BigInteger.Parse(Console.ReadLine());
        BigInteger tribonacciMinusTwo = BigInteger.Parse(Console.ReadLine());
        BigInteger tribonacciMinusOne= BigInteger.Parse(Console.ReadLine());
        ushort n = ushort.Parse(Console.ReadLine());

        BigInteger tribonacci = 0;

        if (n == 1)
        {
            tribonacci = tribonacciMinusThree;
        }
        else if (n == 2)
        {
            tribonacci = tribonacciMinusTwo;
        }
        else if (n == 3)
        {
            tribonacci = tribonacciMinusOne;
        }
        else
	    {
            for (ushort i = 3; i < n; i++)
			{
                tribonacci = tribonacciMinusOne + tribonacciMinusTwo + tribonacciMinusThree;
                tribonacciMinusThree = tribonacciMinusTwo;
                tribonacciMinusTwo = tribonacciMinusOne;
                tribonacciMinusOne = tribonacci;
			}
	    }

        Console.WriteLine(tribonacci);
    }
}