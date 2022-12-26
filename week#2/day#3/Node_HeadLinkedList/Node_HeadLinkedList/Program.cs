using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_HeadLinkedList
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
        public static node head = null;

        // Function to insert an element at head position
        public static void insertathead(int val)
        {
            node n = new node(val);
            n.next = head;
            head = n;
        }


        //print singly linked list
        public static void print()
        {
            node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "  \n");
                temp = temp.next;
            }
            Console.WriteLine("");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
               
                insertathead(383);
                insertathead(484);
                insertathead(392);
                insertathead(975);
                insertathead(321);



                Console.Write("After insertion at tail: \n");
                print();
                Console.WriteLine();

                Console.ReadLine();





            }
        }
    }
}
