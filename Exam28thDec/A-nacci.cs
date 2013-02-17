using System;

class Anacci
{
    static void Main()
    {
        char[] anacciSequence = new char[84];
        anacciSequence[0] = char.Parse(Console.ReadLine());
        anacciSequence[1] = char.Parse(Console.ReadLine());
        byte lines = byte.Parse(Console.ReadLine());

        for (byte i = 2; i < anacciSequence.Length; i++)
        {
            anacciSequence[i] = (char)(64 + ((((anacciSequence[i - 1] - 64) + (anacciSequence[i - 2] - 64)) % 26) == 0 ? 26 : (((anacciSequence[i - 1] - 64) + (anacciSequence[i - 2] - 64)) % 26))); 
        }

        string spaceString = "";

        Console.WriteLine(anacciSequence[0]);
        
        if (lines > 1)
        {
            for (byte i = 0, j = 0; i < lines - 1; i++, j+=2)
            {
                spaceString = new string(' ', i);
                Console.WriteLine(anacciSequence[j + 1] + spaceString + anacciSequence[j + 2]);
            }
        }        
    }
}