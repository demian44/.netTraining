using System;

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
