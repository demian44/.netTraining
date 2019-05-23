﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
            //    Int16 myInt = 8;
            //    Type type = myInt.GetType();
            //    Console.WriteLine(type);
            //    Console.ReadKey();


            // Call function to get and display the attribute.
            //GetAttribute(typeof(MainApp));
            //ViewInfo(new Dog().GetType());
            var dog = new Dog { Age = 12, Name = "pepin" };
            ViewFields(dog);
        }
        public static void ViewInfo(Type type)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}'s information:", type);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Base: {0}", type.BaseType);
            Console.WriteLine("IsAbstract: {0}", type.IsAbstract);
            Console.ReadKey();
        }

        public static void ViewFields(object dog)
        {
            var type = dog.GetType();
            foreach (var propertie in type.GetProperties())
            {
                Console.WriteLine($"{propertie.Name}: {propertie.GetValue(dog)}");
            }

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{type}'s fields:");
            Console.ForegroundColor = ConsoleColor.White;
            IEnumerable<string> fields = type.GetProperties().Select(x => x.Name); //En caso de que tenga atributos publicso
            foreach (string field in fields)
            {
                Console.WriteLine(" - {0}", field);
            }
            Console.WriteLine("{0}'s properties:", type);
            Console.ForegroundColor = ConsoleColor.White;
            IEnumerable<string> properties = from property in type.GetProperties() select property.Name; //En caso de que tenga atributos publicso
            foreach (string property in properties)
            {
                Console.WriteLine(" - {0}", property);
            }
            Console.ReadKey();

            Console.WriteLine("{0}'s methods:", type);
            Console.ForegroundColor = ConsoleColor.White;
            IEnumerable<string> methods = from method in type.GetMethods() select method.Name; //En caso de que tenga atributos publicso
            foreach (string method in methods)
            {
                Console.WriteLine(" - {0}", method);
            }
            Console.ReadKey();

        }
    }

    public class Animal
    {

    }
    public class Dog : Animal
    {
        private int age;
        private string name;
        public string race;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
    }

    public class pet<T/*, U*/>
    {
        private T myObject;

        public T MyObject { get => myObject; set => myObject = value; }

        public void AnaliseType()
        {
            MethodInfo method = this.myObject.GetType().GetMethod("Eat");

        }
    }
}