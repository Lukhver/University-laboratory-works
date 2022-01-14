using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1_13_Lukhverchyk
{
    class Program
        //13.Дано тризначне число. У ньому закреслили першу зліва цифру і приписали її справа.Вивести отримане число.
    {
        static void Main(string[] args)
        {
            Console.Title = "Expressions_13_Lukhverchyk";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.Write("Введiть тризначне число:");
            string caunt = Console.ReadLine();
            Console.WriteLine($"{caunt[1]}{caunt[2]}{caunt[0]}");
            Console.ReadKey();
        }

    }
}