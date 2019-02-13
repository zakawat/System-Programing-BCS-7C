using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventNamespace
{
    class Program
    {
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        static string dataFromServer = "";

        static void Main(string[] args)
        {

            Console.WriteLine("Simulating webservice call by waiting for FOUR seconds...");
            Thread thread = new Thread( () => GetDataFromServer() );
            thread.Start();

            //Put the current thread into waiting state until it receives the signal
            autoResetEvent.WaitOne();

            //Thread got the signal
            Console.WriteLine(dataFromServer);
            Console.ReadKey();
        }

        static void GetDataFromServer()
        {
            //Calling any webservice to get data
            Thread.Sleep(TimeSpan.FromSeconds(4));
            dataFromServer = "Webservice data";
            autoResetEvent.Set();
        }
    }
}
