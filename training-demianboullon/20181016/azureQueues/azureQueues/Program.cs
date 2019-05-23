using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Queue; // Namespace for Queue storage types

namespace azureQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            CloudQueue queue = queueClient.GetQueueReference("my-first-queue");
            queue.CreateIfNotExists();

            CloudQueueMessage message = queue.GetMessage();
            message.SetMessageContent("Updated message...");
            queue.UpdateMessage(message,
                TimeSpan.FromSeconds(0.0),
                MessageUpdateFields.Content | MessageUpdateFields.Visibility);

            CloudQueueMessage peekedMessage = queue.PeekMessage();
            Console.WriteLine(peekedMessage.AsString);

            queue.FetchAttributes();
            Console.WriteLine("Count of queues: ",queue.ApproximateMessageCount.ToString());

            //queue.Delete();
            Console.ReadKey();

        }
    }
}

