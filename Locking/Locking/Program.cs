using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locking
{
    class Program
    {
        static void Main(string[] args)
        {

            // © 2019 - Syed Zakawat - All Rights Reserved



            /*
             * 
             * I knew what this code was doing the time I wrote this
             * But now only GOD knows what it’s doing !! 🤣 🤣 😂
             * 
             */

            Account account = new Account();
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                Thread thread = new Thread(()=> {
                    if (i > 5)
                        account.widthraw(800);
                    else
                        account.deposit(random.Next(200, 1000));
                });
                thread.Start();
            }
            Console.WriteLine(account.inquire());

            Console.ReadKey();
        }
    }
}
