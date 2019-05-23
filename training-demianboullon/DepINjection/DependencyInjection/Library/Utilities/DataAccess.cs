using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public class DataAccess : IDataAccess
    {
        ILogger logger;
        public DataAccess(ILogger logger)
        {
            this.logger = logger;
        }
        public void LoadData()
        {
            Console.WriteLine("Loading data");
            Console.WriteLine("Loading data");
        }
        public void SaveData(string name)
        {
            Console.WriteLine($"Save data { name }");
            Console.WriteLine("Saving data");
        }

    }
}
