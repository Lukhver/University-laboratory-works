using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TASK1_6_Lukhverchyk
{
    class Program
    //Дано двозначне число. Вивести через пробіл його ліву цифру (десятки) і праву цифру(одиниці).
    {
        static void Main(string[] args)
        {
            Console.Title = "Expressions_6_Lukhverchyk";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.Write("Введiть двозначне число: ");
            string a = Console.ReadLine();
            Console.WriteLine($"{a[0]} {a[1]}");
            Console.ReadKey();
        }
    }
}