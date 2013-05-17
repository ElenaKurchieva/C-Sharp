using System;

class Carpets
{
    static void Main() 
    {
        byte n = byte.Parse(Console.ReadLine());
        string dotString = "";
        //byte numberOfCarpets = (byte)((((n / 2) / 2) % 2) == 0 ? (n / 2) / 2 : ((n / 2) / 2 + 1));
        byte count = 0;
        byte numberOfSlashes = 2;
        string carpetString = "/\\";

        for (byte i = 0; i < n / 2; i++)
        {
            if (count == 2)
            {
                numberOfSlashes += 2;
                count = 0;
                carpetString = carpetString.Substring(0, carpetString.Length / 2) + "/\\" + carpetString.Substring(carpetString.Length / 2, carpetString.Length / 2);
            }
            else if (i > 0)
            {
                carpetString = carpetString.Substring(0, carpetString.Length / 2) + "  " + carpetString.Substring(carpetString.Length / 2, carpetString.Length / 2);
            }
            
            dotString = new string('.', n / 2 - 1 - i);
            Console.WriteLine(dotString + carpetString + dotString);
            count++;
        }

        carpetString = carpetString.Replace('/', '|');
        carpetString = carpetString.Replace('\\', '/');
        carpetString = carpetString.Replace('|', '\\');

        count = 0;
        for (int i = n / 2; i > 0; i--)
        {
            if (count == 2)
            {
                numberOfSlashes += 2;
                count = 0;
                carpetString = carpetString.Substring(0, carpetString.Length / 2 - 1) + carpetString.Substring(carpetString.Length / 2 + 1, carpetString.Length / 2 - 1);
            }
            else if (i < n / 2)
            {
                carpetString = carpetString.Substring(0, carpetString.Length / 2 - 1) + carpetString.Substring(carpetString.Length / 2 + 1, carpetString.Length / 2 - 1);
            }

            dotString = new string('.', n / 2 - i);
            Console.WriteLine(dotString + carpetString + dotString);
            count++;
        }
    }
}
