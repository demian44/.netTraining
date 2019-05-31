using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass { id = 1};
            myClass = null;
            if (myClass?.id == 1)
            {
                Console.WriteLine("Entry");
            }
            else
                Console.WriteLine("NO");
            Console.ReadKey();
        }


        class MyClass
        {
            public int id;
        }
    }
}
