using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroes;
namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHeroOne = new SuperHero(new Laser());
            SuperHero superHeroTwo = new SuperHero(new Flying());
            SuperHero superHeroThree = new SuperHero(null);
            superHeroOne.ApplyPower();
            superHeroTwo.ApplyPower();
            superHeroThree.ApplyPower();
            Console.ReadKey();
        }
    }
}
