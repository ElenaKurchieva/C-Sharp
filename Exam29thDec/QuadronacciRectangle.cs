using System;

class QuadronacciRectangle
{
    static long NextQuadronacci(long quadronacciMinusFour, long quadronacciMinusThree, long quadronacciMinusTwo, long quadronacciMinusOne)
    {
        return quadronacciMinusFour + quadronacciMinusThree + quadronacciMinusTwo + quadronacciMinusOne;
    }
        
    static void Main()                                    
    {
        long quadronacciMinusFour = long.Parse(Console.ReadLine());
        long quadronacciMinusThree = long.Parse(Console.ReadLine());
        long quadronacciMinusTwo = long.Parse(Console.ReadLine());
        long quadronacciMinusOne = long.Parse(Console.ReadLine());
        byte rows = byte.Parse(Console.ReadLine());
        byte cols = byte.Parse(Console.ReadLine());

        long[] quadronacciStart = new long[4];
        quadronacciStart[0] = quadronacciMinusFour;
        quadronacciStart[1] = quadronacciMinusThree;
        quadronacciStart[2] = quadronacciMinusTwo;
        quadronacciStart[3] = quadronacciMinusOne;
        ushort count = 0;
        long quadronacci = 0;
       
        for (byte i = 0; i < rows; i++)
        {
            for (byte j = 0; j < cols; j++)
            {
                if (count < 4)
                {
                    Console.Write(quadronacciStart[count]);
                    count++;
                }
                else
                {
                    quadronacci = NextQuadronacci(quadronacciMinusFour, quadronacciMinusThree, quadronacciMinusTwo, quadronacciMinusOne);
                    Console.Write(quadronacci);
                    quadronacciMinusFour = quadronacciMinusThree;
                    quadronacciMinusThree = quadronacciMinusTwo;
                    quadronacciMinusTwo = quadronacciMinusOne;
                    quadronacciMinusOne = quadronacci;
                }
                if (j < cols - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}