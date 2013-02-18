using System;

class WeAllLoveBits
{
    static void Main()
    {
        ushort n = ushort.Parse(Console.ReadLine());
        int p = 0;
        int pMirror = 0;
        byte length;

        for (ushort i = 0; i < n; i++)
        {
            p = int.Parse(Console.ReadLine());

            pMirror = 0;

            length = (byte)Convert.ToString(p, 2).Length;

            for (byte j = 0; j < length; j++)
            {
                pMirror += ((p & (1 << j)) >> j) << (length - 1 - j);
            }

            Console.WriteLine((p ^ (~p)) & pMirror);
        }

        /*int y = ((n * 0x00082082 & 0x01122408) % 255) >> 2;

        Console.WriteLine(Convert.ToString(n, 2));
        Console.WriteLine(Convert.ToString(y, 2));*/
    }
}