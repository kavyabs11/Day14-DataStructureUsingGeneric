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
        public void AddFront(int data) // add front to the list
        {
            Node node = new Node(data);
            if (this.head == null) //head has the value 70 hence else part will execute
                this.head = null;
            else
            {
                node.next = this.head; //next reference is fed with 70 so the 30 will sit front of 70
                this.head = node;
            }
            Console.WriteLine($"Added {node.data} to the front");
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
