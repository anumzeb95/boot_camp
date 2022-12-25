using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    public class bird
    {
        public string motion { get; set; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        



    }

    class parrot : bird
    {
        public void getmotion()
        {
           string motion = "fly";
            Console.WriteLine("I am parrot and i can " + motion + "\n");
        }
    }

    class dog : bird
    {
        public void getmotion()
        {
            string motion = "run";
            Console.WriteLine("I am a dog and i can't fly. I just "
                + motion);
        }
    }

}
