using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class SuperHero
    {
        IPower power;
        public SuperHero(IPower power)
        {
            this.power = power;
        }

        /// <summary>
        /// Use his/her super power.
        /// </summary>
        public void ApplyPower()
        {
            if (power is null)
                Console.WriteLine("I do not know what to do :/.");
            else
                this.power.ApplyPower();
        } 

    }
}
