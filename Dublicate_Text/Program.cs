using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dublicate_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            // Шапка програми
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*****Мій проект****");
            Console.WriteLine("********************");

            // Основна програма
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hello, World!");

            // Блок коду, що дублює написаний текст
            Console.WriteLine($"Введіть текст та натисніть enter");
            var lineFromConsole = Console.ReadLine();
            Console.WriteLine($"Виводимо строку яку ми раніше ввели в консоль: {lineFromConsole}");

            Console.ReadLine();
        }
    }
}