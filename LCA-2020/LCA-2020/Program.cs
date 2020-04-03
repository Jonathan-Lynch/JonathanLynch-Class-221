using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Jonathan";
            string middleName = ".C.";
            string lastName = "Lynch";

            string name = firstName + " " + middleName + lastName;

            int size = name.Length;

            Console.WriteLine(name);
            Console.WriteLine("length is" + size);
        }
    }
}
