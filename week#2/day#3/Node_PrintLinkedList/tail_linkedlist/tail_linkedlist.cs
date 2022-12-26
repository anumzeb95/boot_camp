using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_PrintLinkedList
{
    internal class tail_linkedlist
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 302, 164,530,474 };

            LinkedList<int> values = new LinkedList<int>(num);
          

            values.AddFirst(141);
            Display(values, "Test 1: Add 'today' to beginning of the list:");

            Console.ReadLine();
        }

        private static void Display(LinkedList<int> values, string test)
        {
            Console.WriteLine(test);

            foreach (int v in values)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();

        }

    }

}

