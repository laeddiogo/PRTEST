using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> hosts = new Dictionary<int, string>();

            hosts.Add(1,"api");
            hosts.Add(2,"api");
            hosts.Add(3,"api");
            hosts.Add(4,"api");
            hosts.Add(5, "basePR");
            hosts.Add(5, "ChildPR1-basePR");
            hosts.Add(5, "A"); 

            bool p = hosts.Remove(8);
            string t = hosts[1];
            Console.WriteLine("t");
            


        }
    }
}
