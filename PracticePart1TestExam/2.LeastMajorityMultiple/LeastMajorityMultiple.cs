using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        byte a = byte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        byte c = byte.Parse(Console.ReadLine());
        byte d = byte.Parse(Console.ReadLine());
        byte e = byte.Parse(Console.ReadLine());

        uint leastMajorityMultiple = Math.Min(e, Math.Min(d, Math.Min(c, Math.Min(a, b))));
        byte numberDivisibleBy;

        while (true)
        {
            numberDivisibleBy = 0;

            if (leastMajorityMultiple % a == 0)
            {
                numberDivisibleBy++;
            }
            if (leastMajorityMultiple % b == 0)
            {
                numberDivisibleBy++;
            }
            if (leastMajorityMultiple % c == 0)
            {
                numberDivisibleBy++;
            }
            if (leastMajorityMultiple % d == 0)
            {
                numberDivisibleBy++;
            }
            if (leastMajorityMultiple % e == 0)
            {
                numberDivisibleBy++;
            }
            if (numberDivisibleBy >= 3)
            {
                break;
            }
            leastMajorityMultiple++;
        }

        Console.WriteLine(leastMajorityMultiple);
    }
}