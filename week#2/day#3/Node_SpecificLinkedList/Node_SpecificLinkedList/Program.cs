using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_SpecificLinkedList
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

       
        public static void insert(int val)
        {
            node n = new node(val);
            n.next = head;
            head = n;
        }



        // Function to insert an element at the specific position
        public static void insertAfter(int x, int val)
        {
            node element = new node(val);

            if (x == head.data)
            {
                element.next = head.next;
                head.next = element;
                return;
            }
            node temp = head;
            while (temp.data != x)
            {
                temp = temp.next;
                if (temp == null)
                {
                    return;
                }
            }
            element.next = temp.next;
            temp.next = element;

        }



        public static void print()
        {
            node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "  \n");
                temp = temp.next;
            }
           
        }


        internal class Program
        {
            static void Main(string[] args)
            {

                insert(3);
                insert(2);
                insert(1);

                insertAfter(2, 4);
                Console.Write("Element insertion at a specific position: \n");
                print();
                Console.WriteLine();

                Console.ReadLine();

            }

        }
    }
}