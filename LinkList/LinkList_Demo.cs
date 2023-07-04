using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkList
{
    public class LinkList_Demo
    {
        
            public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!= null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
            Console.WriteLine("Link List data = " + data);
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            while(temp != null) 
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void Reverse_Order(int data)
        {
            Node node = new Node(data);
            if(head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;
            }
        }
        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head = head.next;
            Console.WriteLine("First Node Deleted Successfully");
        }
        public void RemoveLast()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            
            if(head.next == null)
            {
                Console.WriteLine("The next element of head is null");
            }
            else
            {
                Node temp = head;
                while(temp.next.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("Remove Last element");

            }

        }
        public void LinkeedSize()
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty Size = 0");
            }
            Node temp = head;
            int count = 1;
            while( temp.next != null)
            {
                count++;
                temp = temp.next;
               
            }
            Console.WriteLine("Size of Linkes List = " + count);
        }
        public int Search(int value)
        {
            Node node = head;
            if (node == null)
            {
                return -1;
            }
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;

        }
    }
}
