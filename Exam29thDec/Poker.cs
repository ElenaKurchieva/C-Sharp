using System;

class Poker
{
    static void Main()
    {        
        byte[] cardsNumbers = new byte[5];
        string input = "";

        for (byte i = 0; i < cardsNumbers.Length; i++)
		{
            input = Console.ReadLine();
            if (!byte.TryParse(input, out cardsNumbers[i]))
            {
                switch (input)
                {
                    case "J":
                        cardsNumbers[i] = 11;
                        break;
                    case "Q":
                        cardsNumbers[i] = 12;
                        break;
                    case "K":
                        cardsNumbers[i] = 13;
                        break;
                    case "A":
                        cardsNumbers[i] = 14;
                        break;
                }
            }
		}

        Array.Sort(cardsNumbers);

        byte?[] countEqual = {1, 1, 1, 1, 1};

        for (byte i = 0; i < cardsNumbers.Length; i++)
        {
            if (countEqual[i] != null)
            {
                for (byte j = (byte)(i + 1); j < cardsNumbers.Length; j++)
                {
                    if (cardsNumbers[j] == cardsNumbers[i])
                    {
                        countEqual[i]++;
                        countEqual[j] = null;
                    }
                }
            }
        }

        byte length = 1;
        byte previousCard = 0;
        for (byte i = 0; i < cardsNumbers.Length; i++)
        {            
            if (cardsNumbers[i] - previousCard == 1)
            {
                length++;
            }
            previousCard = cardsNumbers[i];            
        }

        byte max = 0;
        for (byte i = 0; i < countEqual.Length; i++)
        {
            if (countEqual[i] != null && countEqual[i] > max)
            {
                max = (byte)countEqual[i];                
            }
        }

        byte secondMax = 0;
        byte countMax = 0;
        if (max == 3)
        {
            for (byte i = 0; i < countEqual.Length; i++)
            {
                if (countEqual[i] != null && countEqual[i] < max && countEqual[i] > secondMax)
                {
                    secondMax = (byte)countEqual[i];                
                }
            }
        }
        else if (max == 2)
        {
            for (byte i = 0; i < countEqual.Length; i++)
            {
                if (countEqual[i] == max)
                {
                    countMax++;
                }
            }
        }

        if (max == 5)
        {
            Console.WriteLine("Impossible");
        }
        else if (max == 4)
        {
            Console.WriteLine("Four of a Kind");
        }
        else if (max == 3 && secondMax == 2)
        {
            Console.WriteLine("Full House");
        }
        else if (length == 5 || (cardsNumbers[0] == 2 && length == 4 && cardsNumbers[4] == 14))
        {
            Console.WriteLine("Straight");
        }
        else if (max == 3)
        {
            Console.WriteLine("Three of a Kind");
        }
        else if (max == 2 && countMax == 2)
        {
            Console.WriteLine("Two Pairs");
        }
        else if (max == 2)
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Console.WriteLine("Nothing");
        }
    }
}