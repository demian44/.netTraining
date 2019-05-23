namespace storage_blobs_dotnet_quickstart
{
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Blob;
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Azure Blob storage - .NET Quickstart sample");
            Console.WriteLine();
            ProcessAsync().GetAwaiter().GetResult();

            Console.WriteLine("Press any key to exit the sample application.");
            Console.ReadKey();
        }

        private static async Task ProcessAsync()
        {
            CloudStorageAccount storageAccount = null;
            CloudBlobContainer cloudBlobContainer = null;
            string sourceFile = null;
            string destinationFile = null;

            string storageConnectionString = Environment.GetEnvironmentVariable("storageconnectionstring");

            // Check whether the connection string can be parsed.
            if (CloudStorageAccount.TryParse(storageConnectionString, out storageAccount))
            {
                try
                {
                    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

                    cloudBlobContainer = cloudBlobClient.GetContainerReference("quickstartblobs" + Guid.NewGuid().ToString());
                    await cloudBlobContainer.CreateAsync();

                    BlobContainerPermissions permissions = new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Blob
                    };

                    //We giv the container a public access. 
                    await cloudBlobContainer.SetPermissionsAsync(permissions);

                    string localPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string localFileName = "QuickStart_" + Guid.NewGuid().ToString() + ".txt";

                    // Saving the file path. 
                    sourceFile = Path.Combine(localPath, localFileName);

                    // We write into a new text file. 
                    File.WriteAllText(sourceFile, "Hello, Acom Team!");

                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(sourceFile);
                    await cloudBlockBlob.UploadFromFileAsync(sourceFile);
                                      
                    BlobContinuationToken blobContinuationToken = null;
                    do
                    {
                        var results = await cloudBlobContainer.ListBlobsSegmentedAsync(null, blobContinuationToken);

                        blobContinuationToken = results.ContinuationToken;
                        foreach (IListBlobItem item in results.Results)
                            Console.WriteLine(item.Uri);
                        
                    } while (blobContinuationToken != null);
                    Console.WriteLine();

                    destinationFile = sourceFile.Replace(".txt", "_DOWNLOADED.txt");

                    await cloudBlockBlob.DownloadToFileAsync(destinationFile, FileMode.Create);
                }
                catch (StorageException ex)
                {
                    Console.WriteLine("Error returned from the service: {0}", ex.Message);
                }
                finally
                {
                    Console.WriteLine("Press any key to delete the sample files and example container.");
                    Console.ReadKey();

                    if (cloudBlobContainer != null)
                        await cloudBlobContainer.DeleteIfExistsAsync();

                    Console.WriteLine("Deleting the local source file and local downloaded files");
                    Console.WriteLine();
                    File.Delete(sourceFile);
                    File.Delete(destinationFile);
                }
            }
            else
            {
                Console.WriteLine(
                    "A connection string has not been defined in the system environment variables. " +
                    "Add a environment variable named 'storageconnectionstring' with your storage " +
                    "connection string as a value.");
            }
        }

        private static async Task ProcessTwoAsync()
        {
            CloudStorageAccount storageAccount = null;
            CloudBlobContainer cloudBlobContainer = null;
            string sourceFile = null;
            string destinationFile = null;

            string storageConnectionString = Environment.GetEnvironmentVariable("storageconnectionstring");

            if (CloudStorageAccount.TryParse(storageConnectionString, out storageAccount))
            {
                try
                {
                    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

                    cloudBlobContainer = cloudBlobClient.GetContainerReference("quickstartblobs" + Guid.NewGuid().ToString());
                    await cloudBlobContainer.CreateAsync();
                    Console.WriteLine("Created container '{0}'", cloudBlobContainer.Name);
                    Console.WriteLine();

                    BlobContainerPermissions permissions = new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Blob
                    };
                    await cloudBlobContainer.SetPermissionsAsync(permissions);
                    var pepe = permissions.PublicAccess;

                    string localPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string localFileName = "test.bmp";
                    sourceFile = Path.Combine(localPath, localFileName);

                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference("test.bmp");
                    await cloudBlockBlob.UploadFromFileAsync(sourceFile);

                    Console.WriteLine("Listing blobs in container.");
                    BlobContinuationToken blobContinuationToken = null;
                    do
                    {
                        var results = await cloudBlobContainer.ListBlobsSegmentedAsync(null, blobContinuationToken);

                        blobContinuationToken = results.ContinuationToken;
                        foreach (IListBlobItem item in results.Results)
                            Console.WriteLine(item.Uri);
                        
                    } while (blobContinuationToken != null);
                    Console.WriteLine();

                    destinationFile = sourceFile.Replace(".bmp", "_DOWNLOADED.bmp");
                    Console.WriteLine("Downloading blob to {0}", destinationFile);
                    Console.WriteLine();
                    await cloudBlockBlob.DownloadToFileAsync(destinationFile, FileMode.Create);
                }
                catch (StorageException ex)
                {
                    Console.WriteLine("Error returned from the service: {0}", ex.Message);
                }
                finally
                {
                    Console.WriteLine("Press any key to delete the sample files and example container.");
                    Console.ReadKey();

                    Console.WriteLine("Deleting the container and any blobs it contains");
                    if (cloudBlobContainer != null)
                        await cloudBlobContainer.DeleteIfExistsAsync();

                    Console.WriteLine("Deleting the local source file and local downloaded files");
                    Console.WriteLine();
                    File.Delete(destinationFile);
                }
            }
            else
            {
                Console.WriteLine(
                    "A connection string has not been defined in the system environment variables. " +
                    "Add a environment variable named 'storageconnectionstring' with your storage " +
                    "connection string as a value.");
            }
        }
    }
}
