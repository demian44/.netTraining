using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class Laser : IPower
    {
        public void ApplyPower()
        {
            Console.WriteLine("Shooting lasers!");
        }
    }
}
