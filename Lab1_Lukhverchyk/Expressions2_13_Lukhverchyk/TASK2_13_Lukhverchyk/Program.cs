using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2_6_Lukhverchyk
{
    class Program
    //Oбчислити функцію y=f(x) 
    //Перше із значень, наведених у таблиці, задати як константу, друге - ввести за допомогою клавіатури.
    //y=a*cos(x)-b*sin(x); x=(a-b)^(1/3); a=t^2*b;
    {
        static void Main(string[] args)
        {
            Console.Title = "Expressions_6_Lukhverchyk";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.Unicode;


            double t = 2.2;
            Console.Write("Впишiть значення b:");
            string B = Console.ReadLine();
            double b = Convert.ToDouble(B);
            double a = Math.Pow(t, 2) + b;
            double x = Math.Pow((a-b), 1.0 / 3.0); ;
            double y = ((a * Math.Cos(x)) - (b * Math.Sin(x)));

            Console.WriteLine("a = " + a);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.ReadKey();
        }
    }
}