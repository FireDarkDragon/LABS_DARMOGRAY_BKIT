using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Дармограй Артем ИУ5-32Б";
            Rectangle rect_example = new Rectangle(4, 3);
            Square square_example = new Square(6);
            Circle circle_example = new Circle(5);

            rect_example.Print();
            square_example.Print();
            circle_example.Print();
        }
    }
}
