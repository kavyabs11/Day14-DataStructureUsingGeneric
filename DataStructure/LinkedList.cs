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
        public int count;
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
        public void Find(int data) // remove the last node in the list
        {
            int found = 0;
            Node node = new Node(data);
            node = this.head;
            if (node != null)
            {
                while (node != null)
                {
                    count++;
                    if (node.data == data)
                    {
                        found++;
                        break;
                    }
                    node = node.next;
                }
                if (found == 1)
                {
                    Console.WriteLine($"\n{node.data} is found at index {count}");
                }
                else
                {
                    Console.WriteLine("The list is empty");
                }
            }
        }
        public Node InsertAtParticularPosition(int position, int data)
        {
            int n = 1;
            Node node = new Node(data);
            Node temp = head;
            if (position < 1)
                Console.WriteLine("Invalid position");
            else if (position == 1)
            {
                Node newNode = node;
                newNode.next = temp;
                head = newNode;
                Console.WriteLine($"Inserted {newNode.data} at position {position}");
            }
            else
            {
                while (n != position - 1) //
                {
                    temp = temp.next;
                    n++;
                }
                Node newNode = node;
                newNode.next = temp.next;
                temp.next = newNode;
                Console.WriteLine($"Inserted {newNode.data} at position {position}");
            }
            return head;
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