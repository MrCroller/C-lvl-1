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
            // Задача 1

            //Ввод данных
            Console.Write("Заполнение анкеты. ");
            Console.Write("Напиши свое имя: ");
            string fName = Console.ReadLine();
            Console.Write("Фамилию: ");
            string lName = Console.ReadLine();
            Console.Write("Город: ");
            string sity = Console.ReadLine();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Рост: ");
            string h = Console.ReadLine();
            Console.Write("Вес: ");
            string wt = Console.ReadLine();


            // Задача 5
            Console.SetCursorPosition(20,15);
            //Вывод данных6
            Console.WriteLine($"Имя: {fName}| Фамилия: {lName}| Город: {sity}| Возраст: {age}| Рост: {h}| Вес: {wt}");


            // Задача 2

            //Рассчет ИМТ
            double wtNum = double.Parse(wt);
            double hNum = double.Parse(h);
            hNum = hNum / 100;
            double imt = wtNum / (hNum*hNum);
            Console.SetCursorPosition(45, 16); //Не, ну это для красоты
            Console.WriteLine("Ваш индекс массы тела = " + String.Format("{0:0.0}", imt));


            Console.ReadKey();
        }
    }
}
