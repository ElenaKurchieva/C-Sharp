using System;

class FighterAttack
{
    static bool isInsideTargetArea(int x, int y, int x1, int y1, int x2, int y2)
    {
        if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int plantX1 = int.Parse(Console.ReadLine());
        int plantY1 = int.Parse(Console.ReadLine());
        int plantX2 = int.Parse(Console.ReadLine());
        int plantY2 = int.Parse(Console.ReadLine());
        int fighterX = int.Parse(Console.ReadLine());
        int fighterY = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());

        int leftX = 0;
        int rightX = 0;
        int bottomY = 0;
        int topY = 0;
        int damage = 0;

        if (plantY1 >= plantY2 && plantX1 <= plantX2)
        {
            rightX = plantX2;
            topY = plantY1;
            leftX = plantX1;
            bottomY = plantY2;
        }
        else if (plantY1 <= plantY2 && plantX1 <= plantX2)
        {
            rightX = plantX2;
            topY = plantY2;
            leftX = plantX1;
            bottomY = plantY1;
        }
        else if (plantY1 <= plantY2 && plantX1 >= plantX2)
        {
            rightX = plantX1;
            topY = plantY2;
            leftX = plantX2;
            bottomY = plantY1;
        }
        else if (plantY1 >= plantY2 && plantX1 >= plantX2)
        {
            rightX = plantX1;
            topY = plantY1;
            leftX = plantX2;
            bottomY = plantY2;
        }          


        if (isInsideTargetArea(fighterX + distance, fighterY, leftX, bottomY, rightX, topY))
        {
            damage += 100;
        }
        
        if (isInsideTargetArea(fighterX + distance, fighterY + 1, leftX, bottomY, rightX, topY))
        {
            damage += 50;
        }

        if (isInsideTargetArea(fighterX + distance, fighterY - 1, leftX, bottomY, rightX, topY))
        {
            damage += 50;
        }

        /*if (distance > 0)
        {
            distance++;
        }
        else if (distance < 0)
        {
            distance--;
        }
        else
        {
            if (isInsideTargetArea(fighterX + 1, fighterY, leftX, bottomY, rightX, topY))
            {
                distance++;
            }
            else
            {
                distance--;
            }
        }*/

        if (isInsideTargetArea(fighterX + distance + 1, fighterY, leftX, bottomY, rightX, topY))
        {
            damage += 75;
        }

        Console.WriteLine("{0}%", damage);
    }
}