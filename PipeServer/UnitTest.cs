using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO.Pipes;
using System.IO;

namespace PipeServer
{
    [TestFixture]
    class UnitTest
    {
        public static void ReturnText()
        {
            //async task to run the PipeServer
            Task.Run(() =>
            {

                Server server = new Server();
                server.StartPipeServer("test");


            });


        }

        [TestCase]
        public static void UnitTest_PipeServer()
        {
            using (var sw = new StringWriter())
            {

                using (var sr = new StringReader("This is a question."))
                {
                    Console.SetOut(sw);
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    NamedPipeClientStream client = new NamedPipeClientStream(".", "quizPipe", PipeDirection.In);
                    ReturnText();
                    // The integer in the delay is in milliseconds.
                    Task.Delay(1000).Wait();

                    client.Connect();

                    StreamReader stream = new StreamReader(client);

                    try
                    {
                        string something = stream.ReadLine();
                        if (!(something.Equals(null)))
                        {
                            Assert.AreEqual("This is a question.", something);
                        }
                        else
                        {
                            Assert.Fail();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.ToString());
                    }
                }
            }
            
        }
    }
}
