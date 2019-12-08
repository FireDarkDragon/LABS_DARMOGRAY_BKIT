using System;
using System.Collections;
using System.Collections.Generic;
using LAB2;

namespace LAB3
{
    public static class Program
    {
        public static void Main()
        {
       
            double r1=0, r2=0, s1=0, c1=0;
            bool correct = false;
            while (correct == false)
            {
                Console.WriteLine("Введите ширину прямоугольника");
                string str1 = Console.ReadLine();
                Console.WriteLine("Введите высоту прямоугольника");
                string str2 = Console.ReadLine();
                Console.WriteLine("Введите длину стороны квадрата");
                string str3 = Console.ReadLine();
                Console.WriteLine("Введите радиус окружности");
                string str4 = Console.ReadLine();
                if (double.TryParse(str1, out r1) && double.TryParse(str2, out r2) && double.TryParse(str3, out s1) && double.TryParse(str4, out c1))
                {
                    r1 = double.Parse(str1);
                    r2 = double.Parse(str2);
                    s1 = double.Parse(str3);
                    c1 = double.Parse(str4);
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
            Rectangle r = new Rectangle(r1, r2);
            Square s = new Square(s1);
            Circle c = new Circle(c1);
            ArrayList list = new ArrayList();
            list.Add(r);
            list.Add(s);
            list.Add(c);
            Console.WriteLine("Содержимое площади элементов коллекции ArrayList:");
            foreach (Figure f in list)
                Console.WriteLine(f.GetArea());
            List<Figure> listG = new List<Figure>();
            foreach (Figure f in list)
                listG.Add(f);
            listG.Sort();
            Console.WriteLine("Содержимое коллекции List<Figure>:");
            foreach (Figure f in listG)
                Console.WriteLine(f.ToString());
            Matrix<Figure> m = new Matrix<Figure>(1, 2, 3, new Square(0));
            m[0, 0, 0] = r;
            m[0, 1, 0] = new Rectangle(29, 11);
            m[0, 0, 1] = s;
            m[0, 1, 1] = new Square(29);
            m[0, 0, 2] = c;
            m[0, 1, 2] = new Circle(29.11);
            Console.WriteLine(m);
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Add(m[0, 0, 0]);
            stack.Pop();
            stack.Add(s);
            stack.Add(c);
            string close = Console.ReadLine();
        }
    }
}