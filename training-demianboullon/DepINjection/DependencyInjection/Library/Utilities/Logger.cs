using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string messege)
        {
            Console.WriteLine($"Logging { messege }");
        }
    }
}
