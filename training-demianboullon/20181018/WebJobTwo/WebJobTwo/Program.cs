using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Acom Team!");
            Processing();
            Console.WriteLine("Goodbye!");
            System.Threading.Thread.Sleep(1000);

        }

        /// <summary>
        /// 
        /// </summary>
        static void Processing()
        {
            Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Processing.");
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Processing..");
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Processing...");
                System.Threading.Thread.Sleep(300);
                Console.Clear();
               
            }
        }
    }
}
