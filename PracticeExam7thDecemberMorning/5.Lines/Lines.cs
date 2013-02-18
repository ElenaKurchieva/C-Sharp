using System;

class Lines
{
    static void Main()
    {
        string previousInput = Convert.ToString(0, 2).PadLeft(8, '0');
        string nextInput;
        string[] input = { "", "", "", "", "", "", "", "" };
        byte horisontalLineLength = 0;
        byte verticalLineLength = 0;
        byte lineLength = 0;
        byte numberOfLines = 0;

        for (byte i = 0; i < 8; i++)
        {
            nextInput = Convert.ToString(byte.Parse(Console.ReadLine()), 2).PadLeft(8, '0');

            horisontalLineLength = 0;
            
            for (byte j = 0; j < nextInput.Length; j++)
            {
                input[j] = nextInput[j] + input[j];

                if (nextInput[j] == '1')
                {                    
                    horisontalLineLength++;                   
                }
                else
                {
                    horisontalLineLength = 0;
                }

                if (horisontalLineLength > lineLength)
                {
                    lineLength = horisontalLineLength;
                    numberOfLines = 1;
                }
                else if (horisontalLineLength == lineLength)
                {
                    numberOfLines++;
                }
            }
        }

        for (byte i = 0; i < 8; i++)
        {
            nextInput = input[i];

            verticalLineLength = 0;
            
            for (byte j = 0; j < nextInput.Length; j++)
            {

                if (nextInput[j] == '1')
                {                    
                    verticalLineLength++;                   
                }
                else
                {
                    verticalLineLength = 0;
                }

                if (verticalLineLength > lineLength)
                {
                    lineLength = verticalLineLength;
                    numberOfLines = 1;
                }
                else if (verticalLineLength == lineLength)
                {
                    numberOfLines++;
                }
            }
        }

        if (lineLength == 1)
        {
            numberOfLines /= 2;
        }

        Console.WriteLine(lineLength);
        Console.WriteLine(numberOfLines);
    }
}