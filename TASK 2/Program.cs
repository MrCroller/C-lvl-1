﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            int count = 0;

            Console.WriteLine("Введите число.");
            string x = Console.ReadLine();

            if( int.TryParse(x, out z))
            {
                foreach( char i in x)
                {
                     if (i >= '0' && i <= '9') count++;
                }
            }

            Console.WriteLine($" Символов в числе: {count}");

            Console.ReadKey();
        }
    }
}
