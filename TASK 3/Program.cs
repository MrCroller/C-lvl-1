using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа. 0 прекращает ввод");
            int a = int.Parse(Console.ReadLine());
            int k = 0;
            while (a != 0 )
            {
                if (a > 0 && a % 2 == 1) { k =+ a; }
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Сумма всех нечетных положительных чисел: {k}");


            Console.ReadKey();
        }
    }
}
