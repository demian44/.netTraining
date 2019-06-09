using System;
using System.Globalization;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<<<<<<<<<<<< ENUMS >>>>>>>>>>>>>>\n");
            Console.WriteLine($"CultureInfo.InvariantCulture: " +
                $"{CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(1)}");

            Console.WriteLine($"CultureInfo.CurrentCulture: " +
               $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(1)}");

            Console.WriteLine($"Month in text format: {Months.January}");

            int numberMonth = (int)Months.January;
            Console.WriteLine($"Month in numer format: {numberMonth}");

            // Here I will extract the names of all the enum elements 
            string[] monthsStringArray = Enum.GetNames(typeof(Months));

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("\nShowing the extracted enum array:");
            foreach (var month in monthsStringArray)
            {
                Console.WriteLine($"- {month}");
            }

            // There are a lot of tools and ways to work with this. 
            // You only need play or google what you need
            Console.ReadKey();
        }
    }
}
