using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        // © 2019 - Syed Zakawat - All Rights Reserved
        static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(() =>  printNumbers(5));
            ThreadStart ts2 = new ThreadStart(printAlphabets);

            Thread threadOne = new Thread(ts1);
            Thread threadTwo = new Thread(ts2);

            threadOne.Start();
            threadTwo.Start();



        }


        private static void printNumbers(int l)
        {
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        private static void printAlphabets()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("$%^#@#$%^&%&^&()*()&^%$%#");
                Thread.Sleep(1000);

            }
        }

    }
}
