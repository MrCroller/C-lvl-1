using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TASK
{
     class Complex
     {
            public double im;
            public double re;

            public Complex Minus(Complex x)
            {
            Complex y = new Complex();
                y.im = im + x.im;
                y.re = re - x.re;
                return y;
            }
            public Complex Multi(Complex x)
            {
            Complex y = new Complex();
                y.re = re * x.im - im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public override string ToString()
            {
                return re + "+" + im + "i";
            }
        }
     class Program
      {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex() { re = 1, im = 2};

            Console.WriteLine($"complex1 = {complex1}");

            Complex complex2 = new Complex() { re = 2, im = 2};

            Console.WriteLine($"complex1 = {complex2}");

            Complex result = complex1.Minus(complex2);
            Console.WriteLine($"complex1 - complex2 = {result}");


            result = complex1.Multi(complex2);
            Console.WriteLine($"complex1 * complex2 = {result}");


            Console.ReadKey();
        }
    }
}
