using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class Demo
    {
        public void Check()
        {
            LinkedList<int> check = new LinkedList<int>();
            check.AddLast(3);
            check.AddLast(4);
            check.AddLast(5);   
            check.AddLast(6);
            check.AddFirst(2);
            foreach (int val in check) 
            {
                Console.WriteLine("Elements in Link List " + val);
            }
            Console.WriteLine("Remove a element from a list");
            check.Remove(check.Last);
           
            foreach (int val in check)
            {
                Console.WriteLine("Elements in Link List " + val);
            }
            Console.WriteLine("Count the elements" + check.Count);

            foreach (int val in check)
            {
                Console.WriteLine("Elements in Link List " + val);
            }
            check.Clear();
        }
    }
}
