using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            Console.WriteLine("Enter a Word");
            string anwser = Console.ReadLine();

            string firstLetter = anwser.Substring(0, 1);
            string lastLetter = anwser.Substring(length, -1, 1);
         
        }
    }
}
