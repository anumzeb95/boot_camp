using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1assignment
{
    internal class camellcase
    {
        static void Main(string[] args)
        {
            string cs = "saveChangesInTheEditor";

            int camelcase(string s)
            {
                int count = 1;
                for (int i = 1; i < s.Length; i++)
                {
                    if (char.IsUpper(s[i]))
                    {
                        count++;
                    }
                }

                return count;
            }
            Console.WriteLine(cs);
            Console.WriteLine(camelcase(cs));
            Console.ReadLine();
        }

    }
}
