using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeClient
{
    public class Client
    {
        public string ConnectToPipe()
        {
            string response = "";
            // Open the one-way named pipe to reads data from. (PipeDirection.In)
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "quizPipe", PipeDirection.In))
            {

                // Connect to the pipe or wait until the pipe is available.
                pipeClient.Connect();

                // Now read the text stream that comes in via the named pipe
                using (StreamReader sr = new StreamReader(pipeClient))
                {
                    // Display the text to the console
                    string temp;
                    while ((temp = sr.ReadLine()) != null)
                    {
                        response = temp;
                    }
                }

            }
            return response;
        }
    }
}
