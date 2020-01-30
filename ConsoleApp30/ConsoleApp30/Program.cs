using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите логин");
        string login = Console.ReadLine();
        char[] arr = login.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
            {
            Console.Write(Char.IsNumber(arr[0]) ? "Первым символом не может быть цифра. " : "");
                if (Char.IsNumber(arr[0])) {break;}
            Console.Write(Char.IsLetterOrDigit(arr[i]) ? "В логине должны быть цифры или латинские буквы. " : "");
                if (Char.IsLetterOrDigit(arr[i])) {break;}
            }
        if (arr.Length > 1 && arr.Length <= 10) { } else { Console.WriteLine(" Логин должен быть длинной от 2 до 10 символов"); }

        Console.ReadKey();
        }
    }
}
