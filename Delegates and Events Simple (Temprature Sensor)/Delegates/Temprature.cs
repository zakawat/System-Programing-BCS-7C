using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    public class Temprature
    {

        public delegate void alert(int temp);

        public event alert OnTempratureLow;
        public event alert OnHighTemprature;


        public int temp { get; set; }
        //The ability to have auto property initializers is included since C# 6.0.
        //That’s why the statment temp { get; set; } = 0; has been removed !!

        public void monitor()
        {
            Random random = new Random();

            while (true)
            {
                temp = random.Next(0, 60);

                if (temp < 10)
                {
                    //When low temp is detected This will fire the event
                    OnTempratureLow(temp);    
                }
                else if(temp > 40)
                {
                    OnHighTemprature(temp);
                }

                Thread.Sleep(1000);  //1 second == 1000 mili second
                
            }
        }


        

    }
}
