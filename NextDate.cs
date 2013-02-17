using System;

class NextDate
{
    static void Main()
    {
        byte day = byte.Parse(Console.ReadLine());
        byte month = byte.Parse(Console.ReadLine());
        ushort year = ushort.Parse(Console.ReadLine());

        if ((day == 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)) ||
            (day == 30 && (month == 4 || month == 6 || month == 9 || month == 11)) ||
            (day == 28 && month == 2 && !(year == 2000 || year == 2004 || year == 2008 || year == 2012)) ||
            (day == 29 && month == 2 && (year == 2000 || year == 2004 || year == 2008 || year == 2012)))
        {
            day = 1;
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
        }
        else
        {
            day++;
        }
        Console.WriteLine(day + "." + month + "." + year);
    }
}