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

            hosts.Add(1,"master");
            hosts.Add(1, "c");

            bool p = hosts.Remove(8);
            string t = hosts[1];
            Console.WriteLine("t");
            


        }
    }
}
