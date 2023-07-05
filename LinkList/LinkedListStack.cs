using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class LinkedListStack
    {
        public Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Elements in stack =" + data);
        }
        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void Peek() 
        {
            if (top == null)
            {
                Console.WriteLine("STACK IS EMPTY");
                 return;
            }
            Console.WriteLine("top element is = "+top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("STACK IS EMPTY");
                return;
            }
            Console.WriteLine("Deleted element = " + top.data);
            top = top.next;

        }

              
            
        
    }
}
