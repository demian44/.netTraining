using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace WebJobsSDKSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.LocalTest();

            /*
             * Este código realiza los cambios siguientes:
             * Agrega un proveedor de registro de Application Insights con un filtrado predeterminado; 
             * toda la información y los registros de nivel superior se enviarán ahora a la consola y a
             * Application Insights cuando la ejecución se realiza localmente.
             * Coloca el objeto LoggerFactory en un bloque using para asegurarse de que la salida del registro 
             * se vacíe cuando se cierre el host.
             */
            using (var loggerFactory = new LoggerFactory())
            {
                var config = new JobHostConfiguration();
                var instrumentationKey =
                    ConfigurationManager.AppSettings["APPINSIGHTS_INSTRUMENTATIONKEY"]; //Install-Package System.Configuration.ConfigurationManager -version 4.4.1
                config.DashboardConnectionString = "";
                config.LoggerFactory = loggerFactory
                    .AddApplicationInsights(instrumentationKey, null)
                    .AddConsole();
                var host = new JobHost(config);
                host.RunAndBlock();
            }

        }

        public static void LocalTest()
        {
            var config = new JobHostConfiguration();
            /*
             * Este código realiza los cambios siguientes:
             * Deshabilita el registro del panel. El panel es una herramienta de supervisión heredada y 
             * no se recomienda el registro del panel para escenarios de producción de alto rendimiento.
             * Agrega el proveedor de consola con el filtrado predeterminado.
             */
            config.DashboardConnectionString = "";
            var loggerFactory = new LoggerFactory();
            config.LoggerFactory = loggerFactory
                .AddConsole();

            var host = new JobHost(config);
            host.RunAndBlock();
        }
    }
}
