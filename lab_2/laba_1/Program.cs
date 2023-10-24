using System;

class Program
{
    static void Main(string[] args)
    {
        double a1 = 1.0, b1 = 2.0, c1 = 3.0;
        double a2 = 4.0, b2 = 5.0, c2 = 6.0;

        double determinantMain = a1 * b2 - a2 * b1;
        double determinantX = c1 * b2 - c2 * b1;
        double determinantY = a1 * c2 - a2 * c1;
        
            double x = determinantX / determinantMain;
            double y = determinantY / determinantMain;

            Console.WriteLine("Решение системы:");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

        Console.ReadLine();
       
    }
}

