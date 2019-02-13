using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            // © 2019 - Syed Zakawat - All Rights Reserved

            Temprature tm = new Temprature();

            tm.OnTempratureLow += tempratureCold;

            tm.OnHighTemprature += tempratureHot;
            

            tm.monitor();
            
            Console.ReadKey();
        }

        private static void tempratureHot(int t)
        {
            Console.WriteLine("Sending EMAIL to admin for LOW temp of {0} C",t);
        }

        private static void tempratureCold(int temp)
        {
            Console.WriteLine("Sending SMS to admin for LOW temp of {0} C",temp);
        }
    }
}
