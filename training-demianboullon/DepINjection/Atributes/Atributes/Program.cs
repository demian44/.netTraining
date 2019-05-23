using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Atributes
{
    class Program
    {
        static void Main(string[] args)
        {
           

            ExampleTwo exampleTwo = new ExampleTwo();
            Type type = exampleTwo.GetType();
            Object[] attribuetes = type.GetCustomAttributes(false);
            foreach (Object attribuete in attribuetes)
            {
                if (attribuete is DataAttributte)
                    Console.WriteLine("{0}", ((DataAttributte)attribuete).Data);
                else if (attribuete is ObsoleteAttribute)
                    Console.WriteLine(((ObsoleteAttribute)attribuete).Message);

            }
                       
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Example));
            Example example = new Example();
            XmlElement xmlElement = new XmlDocument().CreateElement("MyObject","ns");
            xmlElement.InnerText = "Hello Southworks";
            TextWriter textWriter = new StreamWriter("../../../serialiced.txt");
            xmlSerializer.Serialize(textWriter, example);
            
            Console.ReadKey();
        }
    }

}
