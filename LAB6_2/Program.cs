using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace LAB6_2
{
    public class AnyAttribute : System.Attribute
    {
        public int Atr_Value { get; set; }
        public AnyAttribute() { Atr_Value = 0; }
        public AnyAttribute(int value)
        {
            Atr_Value = value;
        }
    }

    public class Inspect
    {
        public Inspect() { }
        public Inspect(int a, int b) { }

        [Any]
        public int attr_field;
        public string str;
        private int priv_field;

        public double property { get; set; }
        [Any(4)]
        public int attr_prop { get; set; }

        [Any(3)]
        public void function()
        {
            Console.WriteLine("Hello world!");
        }
        public void function(int a, int b) { }
        private void foo() { }
    }


    namespace lab6_2
    {

        class Program
        {
            static void Main(string[] args)
            {

                Inspect inspected = new Inspect();
                Type type = Type.GetType("lab6_2.Inspect", false, true);

                Console.WriteLine("Конструкторы:");
                foreach (ConstructorInfo ci in type.GetConstructors())
                {
                    Console.Write(" " + type.Name + " (");
                    ParameterInfo[] parameters = ci.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }


                Console.WriteLine("\nПоля:");
                foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
                {
                    Console.WriteLine($" {field.FieldType} {field.Name}");
                }

                Console.WriteLine("\nСвойства:");
                foreach (PropertyInfo prop in type.GetProperties())
                {
                    Console.WriteLine($" {prop.PropertyType} {prop.Name}");
                }

                Console.WriteLine("\nМетоды:");
                foreach (MethodInfo mi in type.GetMethods())
                {
                    string modificator = "";
                    if (mi.IsStatic)
                        modificator += " static ";
                    if (mi.IsVirtual)
                        modificator += " virtual";
                    Console.Write($"{modificator} {mi.ReturnType.Name} {mi.Name} (");
                    ParameterInfo[] parameters = mi.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                        if (i + 1 < parameters.Length) Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }

                Console.WriteLine("\nПоля и свойства с атрибутами:");
                var attributes = type.GetCustomAttributes();
                foreach (PropertyInfo p in type.GetProperties())
                {
                    bool contains = false;
                    foreach (Attribute attr in p.GetCustomAttributes())
                    {
                        if (attr is AnyAttribute) contains = true;
                    }
                    if (contains)
                        Console.WriteLine($" Свойство {p.PropertyType} {p.Name} содержит AnyAttribute");
                }
                foreach (FieldInfo p in type.GetFields())
                {
                    bool contains = false;
                    foreach (Attribute attr in p.GetCustomAttributes())
                    {
                        if (attr is AnyAttribute) contains = true;
                    }
                    if (contains)
                        Console.WriteLine($" Поле {p.FieldType} {p.Name} содержит AnyAttribute");
                }

                foreach (MethodInfo mi in type.GetMethods())
                    if (mi.Name == "function" && mi.GetParameters().Length == 0)
                    {
                        Console.WriteLine($"\nВызов метода {mi.DeclaringType} {mi.Name}:");
                        mi.Invoke(inspected, null);
                    }
                Console.ReadLine();
            }
        }
    }
}