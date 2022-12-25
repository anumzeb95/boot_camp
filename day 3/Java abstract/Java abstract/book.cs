using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_abstract
{
     internal abstract class book
    {
       public abstract void book_name();
  
    }

    class mybook : book
    {
      
        string title = "A tale of two cities";
       
        public override void book_name()
        {
            Console.WriteLine("The title is : " + title);
        }
    }

}
