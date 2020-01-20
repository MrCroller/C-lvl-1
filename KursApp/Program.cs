using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, min;
            Console.WriteLine("Введите первое число.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число.");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число.");
            z = Convert.ToInt32(Console.ReadLine());

            min = x;
             if(y < x && y < z)
            {
                min = y;
            } else if (z < x && z < y)
            {
                min = z;
            }

            Console.WriteLine($"Минимальное число: {min}");

            Console.ReadKey();
        }
    }
}
