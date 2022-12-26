using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_ReverseLinkedlist
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
        public static node head = null;
        static void Node(int data)
        {
            node n = new node(data);
            n.next = head;
            head = n;
        }

        // Function to insert an element at the tail position
        public static void reverselist()
        {
            node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }


        //print singly linked list
        public static void print()
        {
            node curr = head;
            while (curr != null)
            {
                Console.Write(curr.data + "  \n");
                curr = curr.next;
            }
            Console.WriteLine("");
        }
        internal class Program
        {

            static void Main(string[] args)
            {

                Node(1);
                Node(2);
                Node(3);
                Node(4);
                Node(5);

               
                Console.WriteLine("After reversed the linked list: \n");
                list.print();
               
                Console.ReadLine();
            }
        }
    }
}
