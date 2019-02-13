using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // © 2019 - Syed Zakawat - All Rights Reserved

            TcpListener listener = new TcpListener(IPAddress.Loopback, 10000);

            listener.Start();

            while (true)
            {
                Socket socket = listener.AcceptSocket();

                new Thread(() =>
                {

                    Random r = new Random();
                    int lowerBound = r.Next(10, 100), upperBound = r.Next(200, 1000);
                    int secretGuesss = r.Next(lowerBound, upperBound);
                    int score = 0;


                    var networkStream = new NetworkStream(socket);
                    var streamWriter = new StreamWriter(networkStream);
                    var streamReader = new StreamReader(networkStream);
                    streamWriter.AutoFlush = true;




                    streamWriter.WriteLine("Welcome to The Game !!");

                    while (true)
                    {
                        
                        var clientCommand = streamReader.ReadLine();

                        if (clientCommand.Equals("newGuess"))
                        {
                            lowerBound = r.Next(10, 100);
                            upperBound = r.Next(200, 1000);
                            secretGuesss = r.Next(lowerBound, upperBound);

                            Console.WriteLine($"Secret Guess is {secretGuesss}");
                            streamWriter.WriteLine($"{lowerBound}_{upperBound}");
                        }
                        else if (clientCommand.StartsWith("answer"))
                        {
                            var answer = clientCommand.Split('_');
                            int clientGuess = int.Parse(answer[1]);
                            if (clientGuess == secretGuesss)
                            {
                                //correct answer
                                score++;
                                streamWriter.WriteLine("correctAnswer");
                            }
                            else
                            {
                                //Wrong answer
                                streamWriter.WriteLine($"wrongAnswer_{secretGuesss}");
                            }
                        }
                        else if (clientCommand.Equals("quit"))
                        {
                            break;
                        }
                        else if(clientCommand.Equals("score"))
                        {
                            streamWriter.WriteLine(score);
                        }
                        else
                        {
                            streamWriter.WriteLine("Invalid Command !!");
                        }




                    }


                    networkStream.Close();
                    socket.Close();


                }).Start();

                
            }

            listener.Stop();


        }
    }
}
