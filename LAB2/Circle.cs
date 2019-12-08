using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Circle : Figure,IPrint
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return "Круг: радиус = " + Radius + ", площадь = " + GetArea();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}