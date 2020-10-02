using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4_02
{
    class Program
    {
        static int[] ReadToFile(string file) // Метод считывания файла в массив (Задача 2б,в)
        {
            StreamReader sr = new StreamReader(file);
            int lenght = File.ReadAllText(file).Length;
            int[] arr1 = new int[lenght];
            while (true)
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        arr1[i] = Convert.ToInt32(sr.ReadLine());
                        Console.WriteLine($"{arr1[i],5}");
                    }
                    sr.Close();
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }
                return arr1;
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine($"Массив считанный из файла: ");
            int[] arrFile = ReadToFile(@"d:\массив.txt");

            Console.ReadKey();
        }
    }
}
