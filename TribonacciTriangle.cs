using System;

class TribonacciTriangle
{
    static long NextTribonacci(long tribonacciMinusThree, long tribonacciMinusTwo, long tribonacciMinusOne)
    {
        return tribonacciMinusThree + tribonacciMinusTwo + tribonacciMinusOne;
    }

    static void Main()
    {
        long tribonacciMinusThree = long.Parse(Console.ReadLine());
        long tribonacciMinusTwo = long.Parse(Console.ReadLine());
        long tribonacciMinusOne = long.Parse(Console.ReadLine());
        byte lines = byte.Parse(Console.ReadLine());
        long tribonacci = 0;

        Console.WriteLine(tribonacciMinusThree);
        Console.WriteLine(tribonacciMinusTwo + " " + tribonacciMinusOne);

        if (lines > 2)
        {
            for (byte i = 3; i <= lines; i++)
            {
                for (byte j = 0; j < i; j++)
                {
                    tribonacci = NextTribonacci(tribonacciMinusThree, tribonacciMinusTwo, tribonacciMinusOne);
                    tribonacciMinusThree = tribonacciMinusTwo;
                    tribonacciMinusTwo = tribonacciMinusOne;
                    tribonacciMinusOne = tribonacci;
                    if (j != i - 1)
                    {
                        Console.Write("{0} ", tribonacci);
                    }
                    else
                    {
                        Console.Write(tribonacci);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}