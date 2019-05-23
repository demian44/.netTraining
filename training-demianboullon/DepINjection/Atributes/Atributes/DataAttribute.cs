using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributes
{
    public sealed class DataAttributte:Attribute
    {
        string data;

        public string Data { get => data; set => data = value; }
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public DataAttributte()
        {
            this.data = "default text";
            //Console.WriteLine("Initializing Attribute.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public DataAttributte(string data)
        {
            //Console.WriteLine("Initializing With paramas");
            //Console.WriteLine("Initializing the class ExampleTwo");
            if (!String.IsNullOrEmpty(data))
                this.data = data;
        } 
        #endregion


    }
}
