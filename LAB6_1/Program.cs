using System;
using System.Collections.Generic;

namespace LAB6_1
{
    class Program
    {
        public delegate int IntOperation(int a, double koef = 1);

        public static int IntSquared(int a, double koef)
        {
            return (int)(a * a * koef);
        }

        public static int ZeroIfGreaterThenFive(int a, double koef)
        {
            if (a > 5) return 0;
            return (int)(a * koef);
        }

        public static int IntDoubled(int a, double koef)
        {
            return (int)(koef * a * 2);
        }


        public static void ChangeListValues(ref List<int> list, IntOperation op)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = op(list[i]);
            }
        }

        public static void PrintList(List<int> list)
        {
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void ChangeListValuesFunc(ref List<int> list, Func<int, double, int> op)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = op(list[i], 1);
            }
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("До вызова метода");
            PrintList(list);
            ChangeListValues(ref list, ZeroIfGreaterThenFive);
            Console.WriteLine("После вызова метода");
            PrintList(list);

            Console.WriteLine("\nДо вызова метода");
            PrintList(list);
            ChangeListValues(ref list, (x, a) => (x % 2 == 0) ? x + 1 : x);
            Console.WriteLine("После вызова метода");
            PrintList(list);

            Console.WriteLine("\nДо вызова метода");
            PrintList(list);
            ChangeListValuesFunc(ref list, (x, a) => (x % 2 == 0) ? x : x - 1);
            Console.WriteLine("После вызова метода");
            PrintList(list);

        }
    }
}