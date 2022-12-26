using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node_LinkedlistTail
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

        
        public static void insertathead(int val)
        {
            node n = new node(val);
            n.next = head;
            head = n;
        }

        // Function to insert an element at the tail position
        public static void insertattail(int val)
        {
            node element = new node(val);     

            if (head == null)
            {
                head = element;
                return;
            }
            node temp = head;
            element.next = head; 
             head = element;
         

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

                insertathead(474);
                insertathead(530);
                insertathead(164);
                insertathead(302);


                insertattail(141);
                Console.Write("After insertion at tail: \n");
                print();
            

                Console.ReadLine();

            }
        }
    }
}
