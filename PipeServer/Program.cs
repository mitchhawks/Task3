using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            // start server
            Console.WriteLine("Starting server...");
            server.StartPipeServer("Question");
            //start server
            server.StartPipeServer("Answer");
            
        }

        
    }
}
