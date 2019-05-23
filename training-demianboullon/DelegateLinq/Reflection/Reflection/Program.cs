using System;
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
            // ViewFields(new Dog().GetType());

            Pet<Dog> pet = new Pet<Dog>();
            Dog dog = new Dog();
            pet.myObject = dog;
            pet.AnaliseType();
            Console.ReadKey();
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

        public static void ViewFields(Type type)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}'s fields:", type);
            Console.ForegroundColor = ConsoleColor.White;
            IEnumerable<string> fields = from field in type.GetFields() select field.Name; //En caso de que tenga atributos publicso
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

        public void Bark()
        {
            Console.WriteLine("Guau!!");
        }
    }

    public class Pet<T/*, U*/>
    {
        public T myObject;

        public T MyObject { get => myObject; set => myObject = value; }

        public void AnaliseType()
        {
            if (!ReferenceEquals(null,this.myObject)/*((object)this.myObject is null)*/)
            {
                Console.WriteLine("Prueba");
                MethodInfo bark = this.myObject.GetType().GetMethod("Bark");

                var meow = this.myObject.GetType().GetMethod("Meow");
            }
        }
    }
}