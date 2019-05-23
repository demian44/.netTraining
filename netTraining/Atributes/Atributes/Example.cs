using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atributes
{
    [Obsolete]
    public class Example
    {
        public void Execute() { Console.WriteLine("Example"); }
    }

    [Serializable]
    public class ExampleTwo
    {
        public void Execute() { Console.WriteLine("Example"); }
    }
}
