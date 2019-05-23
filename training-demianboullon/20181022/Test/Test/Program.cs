using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //List<string> list = new List<string> { "Hello", " ","World"};
            //string word = string.Join("", list);
            //dynamic dynamicObject = new ExpandoObject();
            //dynamic subObjct = new ExpandoObject();
            //dynamicObject.name = "Demian";
            //dynamicObject.surname = "Boullon";
            //subObjct.age = 29;
            //dynamicObject.subObjct = subObjct;
            //Console.WriteLine(dynamicObject.subObjct.age);

            //Console.WriteLine(word);
            Console.WriteLine(Guid.NewGuid());
            var array = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()};
            var myString = string.Join(", ", array);
            Console.WriteLine();
            Console.ReadKey();



        }
    }
}
