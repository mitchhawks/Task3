using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"quiz.wav");
            player.Play();
            Console.WriteLine("Waiting for question...");
            string question = client.ConnectToPipe();

            Console.WriteLine("Waiting for answer...");
            string answer = client.ConnectToPipe();

            Console.WriteLine("Here's the question: {0}", question);
            Console.WriteLine("Enter your answer: ");
            if (answer == Console.ReadLine())
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect! The correct answer is: {0}", answer);
            }

            Console.Write("Press Enter to finish...");
            Console.ReadLine();
        }

        
    }
}
