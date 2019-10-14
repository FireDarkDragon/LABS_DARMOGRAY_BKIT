using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Дармограй Артем ИУ5-32Б";
            bool correct = false;
            double a = 0, b = 0, c = 0;
            while (correct == false)
            {
                Console.WriteLine("Введите коэффициент a");
                string str1 = Console.ReadLine();
                Console.WriteLine("Введите коэффициент b");
                string str2 = Console.ReadLine();
                Console.WriteLine("Введите коэффициент c");
                string str3 = Console.ReadLine();
                if (double.TryParse(str1, out a) && double.TryParse(str2, out b) && double.TryParse(str3, out c))
                {
                    a = double.Parse(str1);
                    b = double.Parse(str2);
                    c = double.Parse(str3);
                    correct = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициенты введены некорректно.");
                    Console.WriteLine("Пожалуйста, повторите ввод данных.");
                    Console.ResetColor();
                }

            }

        }
    }
}
