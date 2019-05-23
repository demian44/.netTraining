using Library.Utilities;
using System;

namespace Library
{
    public class NewBusinessLogic : IBusinessLogic
    {
        private ILogger logger;
        private IDataAccess dataAccess;
        private IExample example;
        public NewBusinessLogic(ILogger logger, IDataAccess dataAccess, IExample example)
        {
            if (!(logger is null || dataAccess is null))
            {
                this.logger = logger;
                this.dataAccess = dataAccess;
            }
            else
                Console.WriteLine("The Businness constructor recibed null references");
        }
        public void ProcessData()
        {

            this.logger.Log("Starting the processing of data.");
            Console.WriteLine("  --   ");
            Console.WriteLine("Processing the data");
            this.dataAccess.LoadData();
            this.dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine("  --   ");
            this.logger.Log("Finished processing of the data");

        }
    }
}