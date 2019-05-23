using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacOne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IContainer container = ContainerConfig.Build();
                IMachine myObject = container.Resolve<IMachine>();
                myObject.ChargeBattery();
                if (myObject is Drone && !((Drone)myObject).Transport("Garbage"))
                    Console.WriteLine("Error");
                ISpaceShip spaceShip = container.Resolve<SpaceShip>();
                spaceShip.Fly();

            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }

        public interface IPepe
        {
            void DoAnything();
        }
        public class Pepe : IPepe
        {
            public void DoAnything()
            {
                Console.WriteLine("Doing anything");
            }
        }
    }
}
