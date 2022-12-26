using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryarr_search
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
        public int age = 58;
        public override void abc()
        {
            Console.WriteLine("I am a Principal.");
        }

    }
    public class admin : person
    {
        public string name = "Ali";
        public int age = 38;
        public override void abc()
        {
            Console.WriteLine("I am a Admin.");
        }

    }

    public class staff : person
    {
        public string name = "Hamza";
        public int age = 42;
        public override void abc()
        {
            Console.WriteLine("I am a Staff.");
        }

    }

    public class Guard : person
    {
        public string name = "Usama";
        public int age = 60;
        public override void abc()
        {
            Console.WriteLine("I am a Guard.");
        }

    }
}
