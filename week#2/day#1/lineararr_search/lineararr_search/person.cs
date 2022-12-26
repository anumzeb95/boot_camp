using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineararr_search
{
    public class person
    {
        public virtual void abc()
        {
            Console.WriteLine("My desgination....");
        }

    }
    public class student : person
    {
        public string name = "Ayesha";
        public int age = 18;
        public override void abc()
        {
            Console.WriteLine("I am a student.");
        }

    }

    public class teacher : person
    {
        public string name = "Nadia";
        public int age = 34;
        public override void abc()
        {
            Console.WriteLine("I am a teacher.");
        }

    }

    public class Principal : person
    {
        public string name = "Tahir";
        public int age = 58 ;
        public override void abc()
        {
            Console.WriteLine("I am a Principal.");
        }

    }

}
