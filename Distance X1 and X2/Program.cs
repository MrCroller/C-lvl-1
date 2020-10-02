using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_X1_and_X2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 3

            Console.Write("Задай координаты первой точки. X = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задай координаты второй точки. X = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Расстояние между точкой 1[{x1},{y1}] и точкой 2[{x2},{y2}] = {Calculator(x1, y1, x2, y2)}");


            // Задача 4

            int a = 30;
            int b = 40;
            //a = a + b;
            //b = a - b;
            //a = a - b;
            a = a + b - (b = a); // Обмен переменных


            Console.ReadKey();
        }
        static double Calculator(int x1, int y1, int x2, int y2)
        {
            // метод к задаче 3
            double r;
            return r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
