using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_DeleteLinkedlist
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

            public static node head = null;

            public static void insert(int val)
            {
                node n = new node(val);
                n.next = head;
                head = n;
            }

            // Function to insert an element at the specific position
            public static void delete(int x, int val)
            {
                node temp = head, after = null;

                if (temp != null && temp.data == x)
                {

                    head = temp.next;
                    return;

                }
                while (temp != null && temp.data != x)
                {
                    after = temp;
                    temp = temp.next;
                }

                if (temp == null)
                    return;
               after.next = temp.next;
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
                    insert(9);
                    insert(15);
                    insert(4);
                    insert(7);
                    insert(19);
                    insert(2);
                    insert(6);
                    insert(20);
                    insert(8);



                    delete(3, 0);
                    delete(19,5); 
                    delete(8, 9);
                   
                

                    Console.Write("Element insertion at a specific position: \n");
                    print();
                    Console.WriteLine();

                    Console.ReadLine();

                }

            }
        }
    }
}

