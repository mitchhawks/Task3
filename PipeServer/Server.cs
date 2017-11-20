using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeServer
{
    public class Server
    {
        public void StartPipeServer(string s)
        {
            using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("quizPipe", PipeDirection.Out))
            {

                // Wait for client connection
                Console.Write("Waiting for client connection...");
                pipeServer.WaitForConnection();

                //client connected
                Console.WriteLine("Client connected!");
                Console.Write("Enter {0}: ", s);
                try
                {
                    // Read question/answer from user and send to client
                    using (StreamWriter sw = new StreamWriter(pipeServer))
                    {
                        sw.AutoFlush = true;
                        sw.WriteLine(Console.ReadLine());
                    }
                }

                catch (IOException ex) // Pipe is disconnected or broken, show error
                {
                    Console.WriteLine("ERROR! {0}", ex.Message);
                }

            }
        }
    }
}
