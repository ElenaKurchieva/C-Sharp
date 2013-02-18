using System;

class ShipDamage
{
    static void Main()
    {
        int shipX1 = int.Parse(Console.ReadLine());
        int shipY1 = int.Parse(Console.ReadLine());
        int shipX2 = int.Parse(Console.ReadLine());
        int shipY2 = int.Parse(Console.ReadLine());
        int horizont = int.Parse(Console.ReadLine());
        int firstCatapultX = int.Parse(Console.ReadLine());
        int firstCatapultY = int.Parse(Console.ReadLine());
        int secondCatapultX = int.Parse(Console.ReadLine());
        int secondCatapultY = int.Parse(Console.ReadLine());
        int thirdCatapultX = int.Parse(Console.ReadLine());
        int thirdCatapultY = int.Parse(Console.ReadLine());

        int X1 = Math.Min(shipX1, shipX2);
        int X2 = Math.Max(shipX1, shipX2);
        int Y1 = Math.Min(shipY1, shipY2);
        int Y2 = Math.Max(shipY1, shipY2);
        int damage = 0;
                
        if ((firstCatapultX == X1 && firstCatapultY + 2 * (horizont - firstCatapultY) == Y1)
            || (firstCatapultX == X1 && firstCatapultY + 2 * (horizont - firstCatapultY) == Y2)
            || (firstCatapultX == X2 && firstCatapultY + 2 * (horizont - firstCatapultY) == Y1)
            || (firstCatapultX == X2 && firstCatapultY + 2 * (horizont - firstCatapultY) == Y2))
        {
            damage += 25;
        }
        else if ((firstCatapultX == X1 && firstCatapultY + 2 * (horizont - firstCatapultY) > Y1 && firstCatapultY + 2 * (horizont - firstCatapultY) < Y2)
            || (firstCatapultX == X2 && firstCatapultY + 2 * (horizont - firstCatapultY) > Y1 && firstCatapultY + 2 * (horizont - firstCatapultY) < Y2)
            || (firstCatapultX > X1 && firstCatapultX < X2 && firstCatapultY + 2 * (horizont - firstCatapultY) == Y1)
            || (firstCatapultX > X1 && firstCatapultX < X2 && firstCatapultY + 2 * (horizont - firstCatapultY) == Y2))
        {
            damage += 50;
        }
        else if (firstCatapultX > X1 && firstCatapultX < X2 && firstCatapultY + 2 * (horizont - firstCatapultY) > Y1 && firstCatapultY + 2 * (horizont - firstCatapultY) < Y2)
        {
            damage += 100;
        }

        if ((secondCatapultX == X1 && secondCatapultY + 2 * (horizont - secondCatapultY) == Y1)
            || (secondCatapultX == X1 && secondCatapultY + 2 * (horizont - secondCatapultY) == Y2)
            || (secondCatapultX == X2 && secondCatapultY + 2 * (horizont - secondCatapultY) == Y1)
            || (secondCatapultX == X2 && secondCatapultY + 2 * (horizont - secondCatapultY) == Y2))
        {
            damage += 25;
        }
        else if ((secondCatapultX == X1 && secondCatapultY + 2 * (horizont - secondCatapultY) > Y1 && secondCatapultY + 2 * (horizont - secondCatapultY) < Y2)
            || (secondCatapultX == X2 && secondCatapultY + 2 * (horizont - secondCatapultY) > Y1 && secondCatapultY + 2 * (horizont - secondCatapultY) < Y2)
            || (secondCatapultX > X1 && secondCatapultX < X2 && secondCatapultY + 2 * (horizont - secondCatapultY) == Y1)
            || (secondCatapultX > X1 && secondCatapultX < X2 && secondCatapultY + 2 * (horizont - secondCatapultY) == Y2))
        {
            damage += 50;
        }
        else if (secondCatapultX > X1 && secondCatapultX < X2 && secondCatapultY + 2 * (horizont - secondCatapultY) > Y1 && secondCatapultY + 2 * (horizont - secondCatapultY) < Y2)
        {
            damage += 100;
        }

        if ((thirdCatapultX == X1 && thirdCatapultY + 2 * (horizont - thirdCatapultY) == Y1)
            || (thirdCatapultX == X1 && thirdCatapultY + 2 * (horizont - thirdCatapultY) == Y2)
            || (thirdCatapultX == X2 && thirdCatapultY + 2 * (horizont - thirdCatapultY) == Y1)
            || (thirdCatapultX == X2 && thirdCatapultY + 2 * (horizont - thirdCatapultY) == Y2))
        {
            damage += 25;
        }
        else if ((thirdCatapultX == X1 && thirdCatapultY + 2 * (horizont - thirdCatapultY) > Y1 && thirdCatapultY + 2 * (horizont - thirdCatapultY) < Y2)
            || (thirdCatapultX == X2 && thirdCatapultY + 2 * (horizont - thirdCatapultY) > Y1 && thirdCatapultY + 2 * (horizont - thirdCatapultY) < Y2)
            || (thirdCatapultX > X1 && thirdCatapultX < X2 && thirdCatapultY + 2 * (horizont - thirdCatapultY) == Y1)
            || (thirdCatapultX > X1 && thirdCatapultX < X2 && thirdCatapultY + 2 * (horizont - thirdCatapultY) == Y2))
        {
            damage += 50;
        }
        else if (thirdCatapultX > X1 && thirdCatapultX < X2 && thirdCatapultY + 2 * (horizont - thirdCatapultY) > Y1 && thirdCatapultY + 2 * (horizont - thirdCatapultY) < Y2)
        {
            damage += 100;
        }

        Console.WriteLine("{0}%", damage);
    }
}