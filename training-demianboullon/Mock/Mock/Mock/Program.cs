using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestMethod());
            Console.ReadKey();
        }

        private static string TestMethod()
        {
            System.Threading.Thread.Sleep(5000);
            return "Method Response";
        }
    }
}
