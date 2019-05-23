using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace WebJobsSDKSample
{
    public class Functions
    {
        public static void ProcessQueueMessage(
            [QueueTrigger("queue")] string message,
            [Blob("container/{queueTrigger}", FileAccess.Read)] Stream myBlob,
            ILogger logger)
        {
            logger.LogInformation($"Blob name:{message} \n Size: {myBlob.Length} bytes");
        }

    }
}
