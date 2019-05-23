using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace WebJobsSDKSample
{
    class Program
    {
        static void Main()
        {
            using (var loggerFactory = new LoggerFactory())
            {
                var config = new JobHostConfiguration();
                var instrumentationKey =
                    ConfigurationManager.AppSettings["APPINSIGHTS_INSTRUMENTATIONKEY"];
                config.DashboardConnectionString = "";
                config.LoggerFactory = loggerFactory
                    .AddApplicationInsights(instrumentationKey, null)
                    .AddConsole();
                var host = new JobHost(config);
                host.RunAndBlock();
            }
        }
    }
}


/*Packages:
 * Install-Package Microsoft.Azure.WebJobs -version 2.2.0
 * Install-Package Microsoft.Extensions.Logging -version 2.0.1
 * Install-Package Microsoft.Extensions.Logging.Console -version 2.0.1
*/
