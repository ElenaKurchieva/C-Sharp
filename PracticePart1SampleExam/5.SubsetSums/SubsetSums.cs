using System;

class SubsetSums
{
    static void Main()
    {
        long targetSum = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        long input = 0;
        long sum = 0;
        bool setNonEmpty = false;
        uint count = 0;

        long[] set = new long[n];

        for (byte i = 0; i < n; i++)
        {
            input = long.Parse(Console.ReadLine());

            set[i] = input;
        }

        for (uint i = 0; i < (1 << n); i++)                         
        {
            sum = 0;
            setNonEmpty = false;
           
            for (byte j = 0; j < n; j++)                            
            {                                                               
                if ((i & (1 << j)) != 0)                                    
                {
                    sum += set[j];
                    setNonEmpty = true;                 
                }                                                           
            }

            if (setNonEmpty && sum == targetSum)
            {
                count++;
            }                               
        }
        Console.WriteLine(count);
    }
}