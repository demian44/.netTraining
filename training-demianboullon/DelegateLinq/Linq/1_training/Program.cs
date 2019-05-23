using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 9, 5, 7 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in array
                where score > 6
                select score;

            // Execute the query. 
            //foreach (int i in scoreQuery)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.ReadKey();

            List<Example> list = new List<Example>();
            list.Add(new Example { Number = 6, Name = "uno", MyList = new List<string>() });
            list.Add(new Example { Number = 8, Name = "dos", MyList = new List<string>() });
            list.Add(new Example { Number = 4, Name = "uno", MyList = new List<string>() });
            list.Add(new Example { Number = 7, Name = "dos", MyList = new List<string>() });


            IEnumerable<string> filteredList = from element in list where (element.Number % 2 == 0) orderby element.Name ascending select element.Name;

            foreach(string element in filteredList)
            {
               // Console.WriteLine(element);
            }

            IEnumerable<IGrouping<string, Example>> groupList = from element in list /*where element.Number < 6*/ group element by element.Name;
            
            //foreach(IGrouping<string, Example> group in groupList)
            //{
            //    Console.WriteLine("Key: {0}", group.Key);
            //    Console.WriteLine("////////////////");
            //    foreach(Example example in group)
            //    {
            //        Console.WriteLine("{1}: {0}",example.Number, example.Name);
            //    }

            //}

            
            //Console.ReadKey();
            IEnumerable<Example> newList = list.Where(example => example.Number > 6);
            IEnumerable<Char> nameList = newList.SelectMany(element => element.Name);

            foreach(Char myChar in nameList)
            {
                Console.WriteLine("Char: {0} ",myChar);
            }
            Console.ReadKey();
        }
    }

    class Example
    {
        private int number;
        private string name;
        private List<string> list;

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
        public List<string> MyList { get => list; set => list = value; }
    }
}
