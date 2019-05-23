using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class Flying : IPower
    {
        public void ApplyPower()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
