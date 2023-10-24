using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число 1 = ");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите число 2 = ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите число 3 = ");
            int number_3 = Convert.ToInt32(Console.ReadLine());

            int middleNum;


            if ((number_1 > number_2 && number_1 < number_3) || (number_1 > number_3 && number_1 < number_2))
            {
                middleNum = number_1;
            }

            else if ((number_2 > number_3 && number_2 < number_3) || ( number_2 > number_3 &&  number_2 > number_3 ))
            {
                middleNum = number_2;
            }

            else
            {
                middleNum = number_2;
            }

            Console.Write("Среднее число = " + middleNum);

            Console.ReadKey();


        }
    }
}
