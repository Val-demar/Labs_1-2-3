using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y = ");
        int y = Convert.ToInt32(Console.ReadLine());
        double z = Math.Sin(x - y) * Math.Sin(x + y);
        Console.Write("Ответ:" + z);
        Console.ReadKey();
    }
}
