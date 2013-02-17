using System;

class BitBall
{
    static void Main()
    {
        byte[,] topTeam = new byte[8, 8];
        byte[,] bottomTeam = new byte[8, 8];
        byte n;

        for (byte i = 0; i < 8; i++)
        {
            n = byte.Parse(Console.ReadLine());

            for (byte j = 0; j < 8; j++)
            {
                if (((n >> j) & 1) == 1)
                {
                    topTeam[i,j] = 1;
                }
            }
        }

        for (byte i = 0; i < 8; i++)
        {
            n = byte.Parse(Console.ReadLine());

            for (byte j = 0; j < 8; j++)
            {
                if (((n >> j) & 1) == 1)
                {
                    bottomTeam[i, j] = 1;
                }
            }
        }

        for (byte i = 0; i < 8; i++)
        {
            for (byte j = 0; j < 8; j++)
            {
                if (topTeam[i,j] == 1 && bottomTeam[i,j] == 1)
                {
                    topTeam[i, j] = 0;
                    bottomTeam[i, j] = 0;
                }
            }
        }

        bool scoringOpportunity;
        byte topTeamScore = 0;
        for (byte j = 0; j < 8; j++)
        {
            scoringOpportunity = false;
            for (byte i = 0; i < 8; i++)
            {
                if (scoringOpportunity && (bottomTeam[i, j] == 1 || topTeam[i, j] == 1))
                {
                    scoringOpportunity = false;
                }
                if (topTeam[i,j] == 1)
                {
                    scoringOpportunity = true;
                }
            }
            if (scoringOpportunity)
            {
                topTeamScore++;
            }
        }

        byte bottomTeamScore = 0;
        for (byte j = 0; j < 8; j++)
        {
            scoringOpportunity = false;
            for (sbyte i = 7; i >= 0; i--)
            {
                if (scoringOpportunity && (topTeam[i, j] == 1 || bottomTeam[i, j] == 1))
                {
                    scoringOpportunity = false;
                }
                if (bottomTeam[i, j] == 1)
                {
                    scoringOpportunity = true;
                }
            }
            if (scoringOpportunity)
            {
                bottomTeamScore++;
            }
        }

        Console.WriteLine("{0}:{1}", topTeamScore, bottomTeamScore);
    }
}