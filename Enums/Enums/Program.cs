using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var numberMonth = (int)Months.January;
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

    public enum Months
    {
        // The enum values will be incremented from the number that you set in the first element
        January = 1, // If you do not put any number it will start on 0
        February,
        March,
        April,
        May,
        June,
        //  If you set a number here, it will be incremented on one by one 
        // from this point interrupting the previous counting. For example: July = 45
        July,
        August,
        September,
        October,
        November,
        December
    }
}
