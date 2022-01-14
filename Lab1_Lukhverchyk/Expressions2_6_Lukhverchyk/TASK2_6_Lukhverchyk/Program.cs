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
    //y=p^2+t^4; p=x^2-√(|x|); t=(x+a^2)^(1/3)
    {
        static void Main(string[] args)
        {
            Console.Title = "Expressions_6_Lukhverchyk";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.Unicode;


            double x = 4;
            Console.Write("Впишiть значення a: ");
            string A = Console.ReadLine();
            double a = Convert.ToDouble(A);
            double t = Math.Pow((x + Math.Pow(a, 2)), 1.0 / 3.0);
            double p = Math.Pow(x, 2.0) - Math.Sqrt(Math.Abs(x));
            double y = Math.Pow(p, 2.0) + Math.Pow(t, 4.0);
          
            Console.WriteLine("\nt = {0:F2}", t);
            Console.WriteLine("\np = {0:F2}", p);
            Console.WriteLine("\ny = {0:F2}", y);

            Console.ReadKey();
        }
    }
}