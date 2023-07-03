using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class Stack_Demo
    {
        public void Element()
        {
            Stack stack = new Stack();
            stack.Push("Start1");
            stack.Push("HEMANT");
            stack.Push(25);
            stack.Push(2.55);
            stack.Push('H');
            foreach(var item in stack) 
            {
                Console.WriteLine("ALL elments = " + item);
            }
            Console.WriteLine("Count = " + stack.Count);
            Console.WriteLine(stack.Contains(25));
            Console.WriteLine("Display first element " + stack.Peek()); // show only last element
            foreach (var item in stack)
            {
                Console.WriteLine("ALL elments = " + item);
            }
            Console.WriteLine("Show the first element & delet it " + stack.Pop()); // show last element and delet it also
            foreach (var item in stack)
            {
                Console.WriteLine("ALL elments = " + item);
            }
        }
    }
}
