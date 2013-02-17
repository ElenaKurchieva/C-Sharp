using System;

class AngryBits
{
    static void Main()
    {
        int[,] playingField = new int[8, 16];

        int n;

        for (int i = 0; i < 8; i++)
        {
            n = int.Parse(Console.ReadLine());

            for (int j = 0; j < 16; j++)
            {
                if (((n >> j) & 1) == 1)
                {
                    playingField[i, j] = 1;
                }
            }
        }

        bool directionUp = true;
        int flightLength;
        int numberOfPigsHit;
        int score = 0;
        bool hit = false;
        int col;
        int row;

        for (int i = 8; i < 16; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (playingField[j,i] == 1)
                {
                    directionUp = true;
                    flightLength = 0;
                    numberOfPigsHit = 0;
                    hit = false;
                    col = i;
                    row = j;
                    while (!hit)
                    {
                        if (row == 0)
                        {
                            directionUp = false;
                        }
                        if (col == 0 || (!directionUp && row == 7))
                        {
                            break;
                        }
                        if (directionUp)
                        {
                            if (playingField[row - 1, col - 1] == 1)
                            {
                                hit = true;
                                numberOfPigsHit++;                              
                                playingField[row - 1, col - 1] = 0;
                                if (playingField[row, col - 1] == 1)            // 0 0 0
                                {                                               // 0 1 0
                                    numberOfPigsHit++;                          // 1 0 0
                                    playingField[row, col - 1] = 0;             //
                                }              
                                if (playingField[row - 1, col] == 1)
                                {
                                    numberOfPigsHit++;
                                    playingField[row - 1, col] = 0;
                                }
                                if (col - 1 != 0)
                                {
                                    if (playingField[row, col - 2] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row, col - 2] = 0;
                                    }
                                    if (playingField[row - 1, col - 2] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row - 1, col - 2] = 0;
                                    }
                                } 
                                if (row - 1 != 0)
                                {
                                    if (playingField[row - 2, col] == 1)        
                                    {                                               
                                        numberOfPigsHit++;                          
                                        playingField[row - 2, col] = 0;             
                                    }
                                    if (playingField[row - 2, col - 1] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row - 2, col - 1] = 0;
                                    }
                                    if (col - 1 != 0 && playingField[row - 2, col - 2] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row - 2, col - 2] = 0;
                                    }
                                }
                            }
                            else
                            {
                                row--;
                                col--;
                            }
                        }
                        else
                        {
                            if (playingField[row + 1, col - 1] == 1)
                            {
                                hit = true;
                                numberOfPigsHit++;                              // 1 0 0
                                playingField[row + 1, col - 1] = 0;             // 0 1 0
                                if (playingField[row, col - 1] == 1)            // 0 0 0
                                {                                               //
                                    numberOfPigsHit++;                          //
                                    playingField[row, col - 1] = 0;             //
                                }                                
                                if (playingField[row + 1, col] == 1)
                                {
                                    numberOfPigsHit++;
                                    playingField[row + 1, col] = 0;
                                }
                                if (col - 1 != 0)
                                {
                                    if (playingField[row, col - 2] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row, col - 2] = 0;
                                    }
                                    if (playingField[row + 1, col - 2] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row + 1, col - 2] = 0;
                                    }
                                }                                
                                if (row + 1 != 7)
                                {
                                    if (playingField[row + 2, col] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row + 2, col] = 0;
                                    }
                                    if (playingField[row + 2, col - 1] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row + 2, col - 1] = 0;
                                    }
                                    if (col - 1 != 0 && playingField[row + 2, col - 2] == 1)
                                    {
                                        numberOfPigsHit++;
                                        playingField[row + 2, col - 2] = 0;
                                    }
                                }
                            }
                            else
                            {
                                row++;
                                col--;
                            }
                        }
                        flightLength++;
                    }
                    score += flightLength * numberOfPigsHit;
                    playingField[j, i] = 0;
                    break;
                }
            }
        }

        bool cleared = true;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (playingField[j, i] == 1)
                {
                    cleared = false;
                    break;
                }
            }
            if (!cleared)
            {
                break;
            }
        }
        Console.WriteLine("{0} {1}", score, cleared ? "Yes" : "No");
    }
}