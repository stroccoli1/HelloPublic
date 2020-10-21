using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelloWorld CHW = new ConsoleHelloWorld();
            //
            //data aware version as needed:
            //ConsoleHelloWorld CHWDataAware = new ConsoleHelloWorld(ConfigurationManager.ConnectionStrings["MessageDb"].ConnectionString);
            Console.WriteLine(CHW.DefaultMessage);
            Console.WriteLine("Press Any Key");
            Console.ReadLine();
            return;
        }
    }
}
