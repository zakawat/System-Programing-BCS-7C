using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleResourcesInThread
{
    public class Resource
    {
        public int box { get; set; }

        public Resource()
        {
            box = 0;
        }

        public void calculate(int limit)
        {
            lock (this)
            {

                box = 0;
                for (int x = 1; x < limit; x++)
                {
                    box += x;
                    Console.WriteLine($"Calculating for “{Thread.CurrentThread.Name}” .");
                    Thread.Sleep(1000);
                }

                Console.WriteLine($"Answer from 1-{limit} is {box}");
            }
        }

    }
}
