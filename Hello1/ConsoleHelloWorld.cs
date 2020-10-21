using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class ConsoleHelloWorld : MessageManager.Manager
    {
        public ConsoleHelloWorld()
        {
            DefaultMessage = "Hello World";
        }

        //initialize as data - aware:
        public ConsoleHelloWorld(String connString)
        {
            //setup with data connectivity for members...
            DbConnection(connString);
        }

    }
}
