using System;

class MissCat2011
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint[] count = new uint[10];
        byte vote = 0;
        uint maxVotes = 0;
        byte winner = 0;

        for (uint i = 0; i < n; i++)
        {
            vote = byte.Parse(Console.ReadLine());

            count[vote - 1]++;
        }

        for (byte i = 0; i < count.Length; i++)
        {
            if (count[i] > maxVotes)
            {
                maxVotes = count[i];
                winner = (byte)(i + 1);
            }
        }

        Console.WriteLine(winner);
    }
}