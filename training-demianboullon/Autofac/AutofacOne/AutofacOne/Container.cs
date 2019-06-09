using Autofac;
using System;

namespace AutofacOne
{
    public class ContainerConfig
    {
        public static IContainer Build()
        {
            IContainer container = null;
            try
            {
                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterType<Robot>().As<IMachine>();
                builder.Register(drone => { return new Drone(ConsoleColor.Green); }).As<IMachine>();
                builder.RegisterType(typeof(SpaceShip));
                container = builder.Build();
            }
            catch
            {
                throw new Exception("Container Exception");
            }

            return container;
        }
    }

    public class Robot : IMachine
    {
        public void ChargeBattery()
        {
            Console.WriteLine("Charging Battery...");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }

    }

    public class Drone : IMachine, ITransporter
    {
        private ConsoleColor color;
        public Drone(ConsoleColor color)
        {
            this.color = color;
        }

        public void ChargeBattery()
        {

            Console.WriteLine("Connecting to the source energy...");
            System.Threading.Thread.Sleep(2000);
            Console.ForegroundColor = this.color;
            Console.WriteLine("Charging...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }

        public bool Transport(string thing)
        {
            bool succes = false;
            if (!(string.IsNullOrEmpty(thing)))
            {
                Console.Clear();
                Console.WriteLine($"I am transporting {thing}");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                succes = true;
            }
            return succes;
        }
    }

    public interface IMachine
    {
        void ChargeBattery();

    }

    public interface ITransporter
    {
        bool Transport(string thing);
    }

    public class SpaceShip : IMachine, ISpaceShip
    {
        private IMachine machine;
        public SpaceShip(IMachine machine)
        {
            this.machine = machine;
        }
        public void ChargeBattery()
        {
            Console.WriteLine("Charging Fuel");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }

        public void Fly()
        {
            machine.ChargeBattery();
            Console.WriteLine("Fly");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }

    }

    public interface ISpaceShip
    {
        void Fly();
    }
}
