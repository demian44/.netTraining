using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string pepe = "pepe";
            Console.WriteLine(pepe.CountChars());
            Console.ReadKey();
        }
    }

    public static class ExtensionClass
    {
        public static string CountChars(this string str)
        {
            return String.Format("Lengh: {0}" ,str.Length); 
        }
    }

    public class Dog
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
