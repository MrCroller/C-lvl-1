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

            //Неудачная попытка сделать проверку на число
        public static int Summ()
        {
            //string s = Console.ReadLine();
            //int h;
            //var result = TryParse(s, out h);
            //Console.WriteLine(result ? " " : "Не число");
            int a = int.Parse(Console.ReadLine());
            int k = 0;
            while (a != 0)
            {
                
                //Console.WriteLine(result ? " " : "Не число");
                if (a > 0 && a % 2 == 1) { k = k + a; }
                a = int.Parse(Console.ReadLine());
                
            } 
            return k;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа. 0 прекращает ввод");
            Console.WriteLine($"Сумма всех нечетных положительных чисел: {Summ()}");
            Console.ReadKey();
        }
    }
}
