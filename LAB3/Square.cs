using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Square : Rectangle, IPrint
    {
        public Square(double length) : base(length, length) { }
        public override string ToString()
        {
            return "Квадрат: длина = " + Width + ", площадь = " + GetArea();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
