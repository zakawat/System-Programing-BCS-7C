using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locking
{
    public class Account
    {

        public double balance { get; set; } = 0;

        public void deposit(double amt)
        {
            double d = amt;
            balance = balance + d;
        }

        public void widthraw(double amt)
        {
            lock(this)
            {
                if (balance < amt || balance < 1)
                {
                    Console.WriteLine("You can’t widthraw");
                }
                else
                {
                    double d = amt;
                    balance = balance - d;
                } 
            }
        }

        public double inquire()
        {
            double b = balance;
            return b;
        }




    }
}
