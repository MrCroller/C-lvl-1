using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Рост: ");
            string h = Console.ReadLine();
            Console.Write("Вес: ");
            string wt = Console.ReadLine();

            double wtNum = double.Parse(wt);
            double hNum = double.Parse(h);
            hNum = hNum / 100;
            double imt = wtNum / (hNum * hNum);
            Console.WriteLine("Ваш индекс массы тела = " + String.Format("{0:0.0}", imt));

            if (imt < 16) { 
                Console.WriteLine("Выраженный дефицит массы тела");
            } else if (imt >= 16 && imt < 18.5) { 
                Console.WriteLine("Недостаточная масса тела");
            } else if (imt >= 18.5 && imt < 25) {
                Console.WriteLine("Нормальная масса тела");
            } else if (imt >= 25 && imt < 30) { 
                Console.WriteLine("Избыточная масса тела (предожирение)"); 
            } else if (imt >= 30 && imt < 35) { 
                Console.WriteLine("Ожирение 1-ой степени"); 
            } else if (imt >= 35 && imt <=40) {
                Console.WriteLine("Ожирение 2-ой степени");
            } else if (imt > 40) { 
                Console.WriteLine("Ожирение 3-ой степени");
            }



            Console.ReadKey();
        }         
    }
}
