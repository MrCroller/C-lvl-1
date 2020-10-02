using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            login = "root";
            password = "GeekBrains";

            Console.WriteLine("Введите логин: ");
            string login_r = Console.ReadLine();
            

            if (login == login_r)
            {
                Console.WriteLine("Введите пароль: ");
                for(int k = 1; k <= 3; k++)
                {
                    
                    string password_r = Console.ReadLine();

                    if (password == password_r)
                    {
                        Console.WriteLine("Вы вошли");
                        break;
                    } else if(k == 3) { Console.WriteLine("Уупс. Превышены попытки входа :c "); }
                    else
                    {
                        Console.WriteLine("Неверный пароль!");
                    }
                }

            } 
            else
            {
                Console.WriteLine("Логина не существует");
            }
            

            Console.ReadKey();
        }


    }
}
