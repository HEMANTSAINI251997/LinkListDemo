using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
        
    }
}
