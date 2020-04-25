using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> s = new List<int>() { 3, 2, 1 };
            List<int> d = new List<int>();
            List<int> a = new List<int>();

            Move(s.Count, s, d, a, "source", "destination", "aux");
        }

        public static void Move(int how_many, List<int> source, List<int> destination, List<int> aux, string s, string d, string a)
        {
            if (how_many == 1)
            {
                destination.Add(source.Last());
                source.RemoveAt(source.Count - 1);
                Console.WriteLine("Move from {0} to {1}", s, d);
                return;
            }
            else
            {
                Move(how_many - 1, source, aux, destination, s, a, d);
                destination.Add(source.Last());
                source.RemoveAt(source.Count - 1);
                Console.WriteLine("Move from {0} to {1}", s, d);
                Move(how_many - 1, aux, destination, source, a, d, s);
            }
        }
    }
}
