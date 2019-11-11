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
            double a = 0, b = 0, c = 0;
            if (args.Length == 3)
            {
                {
                    if (double.TryParse(args[0], out a) && double.TryParse(args[1], out b) && double.TryParse(args[2], out c))
                    {
                        a = double.Parse(args[0]);
                        b = double.Parse(args[1]);
                        c = double.Parse(args[2]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка ввода коэффициентов через параметры командной строки.");
                        Console.ResetColor();
                    }
                }
            }
            else
            {
                Console.WriteLine("Коэффициенты не были заданы параметрами командной строки.");
                bool correct = false;
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
            double D, x1, x2, x3, x4;
            if(a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        // 0 = 0
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Уравнение имеет бесконечное множество решений");
                        Console.ResetColor();
                    }
                    else
                    {
                        // c = 0 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Решений нет");
                        Console.ResetColor();
                    }
                }
                else
                {
                    // уравнение вида b*x^2 + c = 0 
                    D = -4 * b * c;
                    if (D < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("Решений нет");
                        Console.ResetColor();
                    }
                    else if(D == 0)
                    {
                        // b*x^2 = 0 => x = 0
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = 0");
                        Console.WriteLine("x = 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        x1 = -Math.Sqrt(D) / (2 * b);
                        x2 =  Math.Sqrt(D) / (2 * b);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                        Console.ResetColor();
                    }
                }
            }
            else if(b == 0)
            {
                if(c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("D = 0");
                    Console.WriteLine("x = 0");
                    Console.ResetColor();
                }
                else
                {
                    // a*x^4 + c = 0
                    D = -4 * a * c;
                    if (D < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("Решений нет");
                        Console.ResetColor();
                    }
                    else if (D == 0)
                    {
                        // b*x^2 = 0 => x = 0
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = 0");
                        Console.WriteLine("x = 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        double x_ = Math.Abs(Math.Sqrt(D) / (2 * a));
                        x1 = -Math.Sqrt(x_);
                        x2 = Math.Sqrt(x_);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                        Console.ResetColor();
                    }

                }
            }
            else if(c == 0)
            {
                // a* x^4 + b* x^2 = x^2 * (a*x^2 + b)
                D = -4 * a * b;
                if( D < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x = 0");
                    Console.ResetColor();
                }
                else
                {
                    x1 = -Math.Sqrt(D) / (2 * a);
                    x2 = 0;
                    x3 = Math.Sqrt(D) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("D = {0}", D);
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                    Console.WriteLine("x3 = {0}", x3);
                    Console.ResetColor();
                }
            }
            else
            {
                D = b * b - 4 * a * c;
                if (D < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("D = {0}", D);
                    Console.WriteLine("Решений нет");
                    Console.ResetColor();
                }
                else if(D == 0)
                {
                    double x_ = -b / (2 * a);
                    if(x_ < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("Решений нет");
                        Console.ResetColor();
                    }
                    else
                    {
                        x1 = -Math.Sqrt(x_);
                        x2 =  Math.Sqrt(x_);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                        Console.ResetColor();
                    }
                }
                else
                {
                    double x_1 = (-b - Math.Sqrt(D)) / (2 * a);
                    double x_2 = (-b + Math.Sqrt(D)) / (2 * a);
                    if(x_1 < 0 && x_2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("Решений нет");
                        Console.ResetColor();
                    }
                    else if(x_1 > 0 && x_2 > 0)
                    {
                       if(x_1 > x_2)
                        {
                            x1 = -Math.Sqrt(x_1);
                            x2 = -Math.Sqrt(x_2);
                            x3 = Math.Sqrt(x_2);
                            x4 = Math.Sqrt(x_1);
                        }
                        else
                        {
                            x1 = -Math.Sqrt(x_2);
                            x2 = -Math.Sqrt(x_1);
                            x3 = Math.Sqrt(x_1);
                            x4 = Math.Sqrt(x_2);
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("x1 = {0}",x1);
                        Console.WriteLine("x2 = {0}", x2);
                        Console.WriteLine("x3 = {0}", x3);
                        Console.WriteLine("x4 = {0}", x4);
                        Console.ResetColor();
                    }
                    else if (x_1 > 0)
                    {
                        x1 = -Math.Sqrt(x_1);
                        x2 = Math.Sqrt(x_1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                        Console.ResetColor();
                    }
                    else
                    {
                        x1 = -Math.Sqrt(x_2);
                        x2 = Math.Sqrt(x_2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("D = {0}", D);
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
