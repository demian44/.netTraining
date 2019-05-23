using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //BusinessLogic businessLogic = new BusinessLogic();
            //businessLogic.ProcessData();
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {

                var app = scope.Resolve<IApplication>(); // In this moment, the method try to generate an instance of Application
                app.Run();
            }

            Console.ReadKey();

        }
    }
}
