using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;

namespace autoFacTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            IContainer container = ContainerConfig.BuildOne();
            IMachine machine = container.Resolve<IMachine>(new NamedParameter("function", "transport"));
            ((Drone)machine).Shoot();

            IContainer containerTwo = ContainerConfigTwo.Build();
            /*Robot has an attribute called instanceId, which identifies one instance of others. 
            In this case, we check that we have two objects that refer to the same instance.*/
       
            Console.WriteLine("First Scope....");
            using (var lifeTimeScope = containerTwo.BeginLifetimeScope())
            {
                List<object> myRobotList = new List<object>();
                for (int i = 0; i < 3; i++)
                {
                    myRobotList.Add(lifeTimeScope.Resolve<IMachine>());
                    Console.WriteLine($"id of instance: {((Robot)myRobotList.Last()).InstanceId}");
                }
            }

            Console.WriteLine("Second Scope....");
            using (ILifetimeScope lifeTimeScopeTwo = containerTwo.BeginLifetimeScope())
            {
                for (int i = 0; i < 3; i++)
                {
                    IMachine machineTwo = lifeTimeScopeTwo.Resolve<IMachine>();
                    Console.WriteLine($"id of instance: {((Robot)machineTwo).InstanceId}");
                }
            }
            Console.ReadKey();
        }
    }

    public class ContainerConfig
    {
        public static IContainer BuildOne()
        {

            Dictionary<string, string> pepe = new Dictionary<string, string>();
            string pepito = pepe.First().Key;
            IContainer container = null;
            try
            {
                Autofac.ContainerBuilder containerBuilder = new Autofac.ContainerBuilder();
                containerBuilder.RegisterType<Robot>().As<IMachine>();
                containerBuilder.Register((name, value) =>
                        {
                            IMachine machine;                    
                            if (value.Named<string>("function").Trim().ToLower() == "transport") /// It should be an enum type
                                machine = new Drone();
                            else
                                machine = new Robot();

                            return machine;

                        }).As<IMachine>();
                //builder.RegisterType<Drone>()
                //    .As<IMachine>()
                //    .As<IGun>()
                //    .IfNotRegistered(typeof(IMachine));
                container = containerBuilder.Build();
            }
            catch { throw new Exception("Container Exception"); }
            return container;
        }
    }

    public class ContainerConfigTwo
    {
        public static IContainer Build()
        {
            IContainer container = null;
            try
            {
                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterType<Robot>().SingleInstance()
                     .As<IMachine>();
                builder.RegisterType<Drone>()
                    .AsSelf();
                //.IfNotRegistered(typeof(IMachine));
                builder.RegisterType<FlyingCumbancha>()
                    .AsSelf()
                    .OnlyIf(reg => reg.IsRegistered(new TypedService(typeof(IMachine)))
                                && reg.IsRegistered(new TypedService(typeof(Drone)))) ;
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
