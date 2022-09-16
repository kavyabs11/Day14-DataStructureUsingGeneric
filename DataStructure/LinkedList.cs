using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructure
{
    internal class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data); //creating an object of Node and pushing the data to that object(node)
            if (this.head == null)
            {
                this.head = node; // if the head is null, the data in node will be pushed to head
            }
            else
            {
                Node temp = head; //else the head data is pushed to temp.
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"Added {node.data} to the list");
        }
        public void RemoveFirst() // remove the first node in the list
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            this.head = this.head.next;
            Console.WriteLine("removed the last node from the list");
        }
        public void Display()
        {
            Node temp = this.head; //pushing head data to temp. if head data is null the temp will be null and it will show as empty
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null) //if the head has some data it will be pushed to temp and shows the data
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //moves to next poniter unless temp is null
            }
        }
    }
}