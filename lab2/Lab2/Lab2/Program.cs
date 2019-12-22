using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor consoleColor = Console.BackgroundColor;
            Console.WriteLine(consoleColor);           

            Console.WriteLine("Caps Lock is " + (Console.CapsLock ? "On!" : "Off!"));

            Console.WriteLine("Введіть стоку");

            string  value = Console.ReadLine();
            Console.WriteLine("Ви ввели: " + value);

            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
