using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;

namespace InstancePerMatchingLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {

            IContainer container = ContainerConfig.BuildOne();

            using (ILifetimeScope scope1 = container.BeginLifetimeScope())
            {
                for (int i = 0; i < 100; i++)
                {
                    // Every time you resolve this from within this
                    // scope you'll get the same instance.
                    Robot robotOne = scope1.Resolve<Robot>();
                    Console.WriteLine($"robotOne.InstanceId {robotOne.InstanceId}");
                }
            }

            using (ILifetimeScope scope2 = container.BeginLifetimeScope())
            {
                for (int i = 0; i < 100; i++)
                {
                    // Every time you resolve this from within this
                    // scope you'll get the same instance, but this
                    // instance is DIFFERENT than the one that was
                    // used in the above scope. New scope = new instance.
                    Robot robotTwo = scope2.Resolve<Robot>();
                    Console.WriteLine($"robotOne.InstanceId {robotTwo.InstanceId}");
                }
            }

            Console.ReadKey();
        }
    }

    public class ContainerConfig
    {
        public static IContainer BuildOne()
        {
            IContainer container = null;
            try
            {
                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterType<Robot>().InstancePerMatchingLifetimeScope();
                container = builder.Build();
            }
            catch { throw new Exception("Container Exception"); }
            return container;
        }
    }

    interface INoRegistered
    {
        void myMethod();
    }

    public class Robot : IMachine
    {
        private static int instanceCounter = 0;
        private int instanceId;
        public static int InstanceCounter { get => instanceCounter; }
        public int InstanceId { get => instanceId; set => instanceId = value; }

        public Robot()
        {
            Robot.instanceCounter++;
            this.InstanceId = Robot.InstanceCounter;
        }
        public void ChargeBattery()
        {

            Console.WriteLine("Robot: Charging Battery...");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }

    }
    public class Drone : IMachine, IGun
    {

        public void ChargeBattery()
        {

            Console.WriteLine("Drone: Connecting to the source energy...");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Drone: Charging...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }

        public void Shoot()
        {
            Console.WriteLine("Pum pum!");
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

    interface IGun
    {
        void Shoot();
    }

    public class FlyingCumbancha : IMachine
    {
        Drone drone;
        IMachine robot;
        public FlyingCumbancha(IMachine robot, Drone drone)
        {
            this.drone = drone;
            this.robot = robot;
        }
        public void ChargeBattery()
        {

            Console.WriteLine("FlyingCumbancha: Come up.");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("FlyingCumbancha: I said... come up.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
    }
    public interface IMachine
    {
        void ChargeBattery();

    }
}
