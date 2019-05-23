using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat> { new Cat("Marcelo",5), new Cat("Jorge",5), new Cat("Claudio",10), new Cat("Cacho", 10) };
            IEnumerable<IGrouping<int,Cat>> groupCats = cats.GroupBy(cat => cat.Age);
            foreach(IGrouping<int,Cat> myGroupedCats in groupCats)
            {
                Console.WriteLine(myGroupedCats.Key);
                foreach(Cat theCat in myGroupedCats)
                {
                    Console.WriteLine(theCat.Name);
                }
            }

            Console.ReadKey();
        }
    }
    
    public class Cat
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Cat(string name, int age) { this.name = name; this.age = age; }
    }
}
