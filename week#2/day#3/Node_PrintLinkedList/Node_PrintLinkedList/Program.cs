using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_PrintLinkedList
{
    internal class Program
    {

        public class node
        {
            public int data;
            public node next;

            public node(int value)
            {
                data = value;
                next = null;
            }
        }

        public class list
        {

            // Declaring an empty linked list
            public static node add = null;

            // Function to insert an element at position
            public static void insert(int val)
            {
                node n = new node(val);
                n.next = add;
                add = n;
            }


            //print singly linked list
            public static void print()
            {
                node temp = add;
                while (temp != null)
                {
                    Console.Write(temp.data + "  \n");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }

            static void Main(string[] args)
            {

                insert(16);
                insert(13);

                Console.Write("The linked list contain values as: \n");
                print();
                Console.WriteLine();

                Console.ReadLine();

            }


        }

    }
}
   
