using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        int iterations = 3;

        do
        {
            iterations--;
            if (input[input.Length - 1] == '0')
            {
                input = input.Substring(0, input.Length - 1);
            }
            else
            {
                input = input[input.Length - 1] + input.Substring(0, input.Length - 1);
            }

        } while (iterations > 0);

        Console.WriteLine(input);
    }
}