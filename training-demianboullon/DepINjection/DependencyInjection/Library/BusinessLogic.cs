using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BusinessLogic : IBusinessLogic
    {
        private ILogger logger;
        private IDataAccess dataAccess;
        private IExample example;
        public BusinessLogic(ILogger logger, IDataAccess dataAccess, IExample example)
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
            Console.WriteLine("Processing the data");
            this.dataAccess.LoadData();
            this.dataAccess.SaveData("ProcessedInfo");
            this.logger.Log("Finished processing of the data");

        }
    }
}
