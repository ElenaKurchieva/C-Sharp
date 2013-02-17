using System;

class FormulaBit1
{
    static void Main()
    {
        byte[,] grid = new byte[8, 8];
        byte input = 0;
        
        for (byte i = 0; i < 8; i++)
        {
            input = byte.Parse(Console.ReadLine());
            for (byte j = 0; j < 8; j++)
            {
                if (((input >> j) & 1) == 1)
                {
                    grid[i, j] = 1;
                }
            }
        }

        bool directionDown = true;
        byte trackLength = 1;
        bool directionLeft = false;
        bool endOfTrack = false;
        byte col = 0;
        byte row = 0;
        if (grid[row , col] == 1)
        {
            Console.WriteLine("No 0");
            return;
        }
        int numberOfDirectionSwitches = -1;

        while (!endOfTrack && !(col == 7 && row == 7))
        {
            if (directionDown && !directionLeft)
            {
                if (row == 7 || grid[row + 1, col] == 1)
                {
                    endOfTrack = true;
                }
                else
                {
                    numberOfDirectionSwitches++;
                }
                while (true)
                {
                    if (row == 7 || grid[row + 1, col] == 1)
                    {
                        break;
                    }
                    row++;
                    trackLength++;
                }
                directionDown = false;
                directionLeft = true;
            }
            else if (directionLeft && !directionDown)
            {
                if (col == 7 || grid[row, col + 1] == 1)
                {
                    endOfTrack = true;
                }
                else
                {
                    numberOfDirectionSwitches++;
                }
                while (true)
                {
                    if (col == 7 || grid[row, col + 1] == 1)
                    {
                        break;
                    }
                    col++;
                    trackLength++;
                }
                directionLeft = false;
            }
            else if (directionLeft && directionDown)
            {
                if (col == 7 || grid[row, col + 1] == 1)
                {
                    endOfTrack = true;
                }
                else
                {
                    numberOfDirectionSwitches++;
                }
                while (true)
                {
                    if (col == 7 || grid[row, col + 1] == 1)
                    {
                        break;
                    }
                    col++;
                    trackLength++;
                }
                directionLeft = false;
            }
            else if (!directionDown && !directionLeft)
            {
                if (row == 0 || grid[row - 1, col] == 1)
                {
                    endOfTrack = true;
                }
                else
                {
                    numberOfDirectionSwitches++;
                }
                while (true)
                {
                    if (row == 0 || grid[row - 1, col] == 1)
                    {
                        break;
                    }
                    row--;
                    trackLength++;
                }
                directionDown = true;
                directionLeft = true;
            }
        }
        Console.WriteLine(endOfTrack ? ("No " + trackLength) : (trackLength + " " + numberOfDirectionSwitches));                
    }
}