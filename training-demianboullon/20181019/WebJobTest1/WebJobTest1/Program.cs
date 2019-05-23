using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(3000);
            System.Diagnostics.Trace.TraceInformation($"Test - {DateTime.UtcNow.ToString()}");
        }
    }
}
