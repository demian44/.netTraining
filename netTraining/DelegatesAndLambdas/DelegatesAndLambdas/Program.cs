using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdas
{
    class Program
    {
        public delegate string Reverse(string s);

        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }



        static void Main(string[] args)
        {
            Reverse rev = ReverseString;

            //Console.WriteLine(rev("a string"));
            ClassWithFunction classWithFunction = new ClassWithFunction("Prueba");
            ClassWithDelegate classWithDelegate = new ClassWithDelegate();
            //classWithDelegate.myDelegate = classWithFunction.DelegateFunction;
            //classWithDelegate.myDelegate.Invoke("parameter one", 100);
            //classWithDelegate.myDelegate = delegate (string myString, int myInt) { return String.Format("Delegate: {1} {0}", myString, myInt); };
            classWithDelegate.myDelegate = (string myString, int myInt) => string.Format("Lambda: {1} {0}", myString, myInt);
            Console.WriteLine(classWithDelegate.myDelegate.Invoke("Bla", 100));
            Console.ReadKey();
        }
    }


    public class ClassWithDelegate
    {
        public delegate string MyNewDelegate(string myString, int myInt);
        private int id;
        public MyNewDelegate myDelegate;

        public int Id { get => id; set => id = value; }
        public void ExecuteDelegateFunction(string myString, int myInt)
        {
            this.myDelegate.Invoke(myString, myInt);
        }

    }

    class ClassWithFunction
    {
        private string name;
        public ClassWithFunction(string parameterName)
        {
            if (!string.IsNullOrEmpty(parameterName))
                this.name = parameterName;
            else
                this.name = "No - Name";
        }
        public string DelegateFunction(string theString, int theInt)
        {
            Console.WriteLine("String: {0} - Int: {1} - Name: {2}", theString, theInt, this.name);
            return "succes!";
        }
    }
}
