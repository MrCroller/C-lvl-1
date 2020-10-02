using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TASK
{
    class Program
    {
        /*
        static bool TryParse(string str, out int k)
        {
            bool f = int.TryParse(str, out k);
            if (f) return true;
            else return false;
        }
        */
        
        static void Main(string[] args)
        {

            string result = String.Empty;

            int sum = 0;


            Console.WriteLine("Вводите числа. 0 прекращает ввод");
            while (true)
            {
                int a;
                int.TryParse(Console.ReadLine(), out a);
                if (a == 0) break;

                if (a > 0 && a % 2 == 1) { sum += a; }
            }
            Console.WriteLine($"Сумма всех нечетных положительных чисел: {sum}");
            Console.ReadKey();
        }
    }
}
