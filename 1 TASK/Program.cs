using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TASK
{
    class Program
      {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(2, 3);

            Console.WriteLine($"complex1 = {complex1}");

            Complex complex2 = new Complex(-1, 1);

            Console.WriteLine($"complex1 = {complex2}");

            Complex result = new Complex();

            Console.WriteLine("- *");
            string o = Console.ReadLine();
            switch (o)
            {
                case "-": result = complex1.Minus(complex2); break;
                case "*": result = complex1.Multi(complex2); break;
                default: Console.WriteLine("Такой операции нет"); break;
            }
            Console.WriteLine(result.ToString());

            Console.ReadKey();
        }
    }
}
