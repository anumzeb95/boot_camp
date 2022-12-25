using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding_task
{
    public class sport
    {
        string name = "Generic Sport";

        public virtual void Sport()
        {
            Console.WriteLine("Each team has n playesr in " + name);

        }
    }

    public class soccer : sport
    {
            int n = 11;
            string name = "Soccer Class";


         public override void Sport()
         {
            base.Sport(); //Calling 'Sport()' of base class using 'base' keyword
            Console.WriteLine("Each team has " + n + " playesr in " + name);

         }

    }





}
