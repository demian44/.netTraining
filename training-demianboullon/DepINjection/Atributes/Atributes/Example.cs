using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atributes
{
    //[Obsolete]
    [Serializable]
    public class Example
    {
        private int id;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }

        public Example()
        {
            this.id = 1;
            this.description = "Example description";
        }
    }

    [DataAttributte("Text introduced on tag")]
    [Obsolete("This class is deprecated | You must use ExampleThree Class")]
    public class ExampleTwo
    {
        public void Execute() {  }
    }
}
