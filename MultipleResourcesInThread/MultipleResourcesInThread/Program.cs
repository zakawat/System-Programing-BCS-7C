using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleResourcesInThread
{
    class Program
    {
        public static object StopWatch { get; private set; }

        static void Main(string[] args)
        {

            // © 2019 - Syed Zakawat - All Rights Reserved

            Console.Write("Enter the number of resources: ");
            String res = Console.ReadLine();
            int resourceLimit = int.Parse(res);

            List<Resource> resources = new List<Resource>();

            for (int i = 0; i < resourceLimit; i++)
            {
                resources.Add( new Resource() );
            }


            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();

            for (int a = 10; a >= 5; a--)
            {
                var thread = new Thread( delegate()
                {
                    resources[a % resources.Count].calculate(a);
                });
                thread.Name = $"P-{a}";
                thread.Start();
            }

            //Console.WriteLine($"Total time consumed is: “{stopWatch.ElapsedMilliseconds/1000}”seconds");




        }
    }
}
