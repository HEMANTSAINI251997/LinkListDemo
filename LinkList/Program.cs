using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class Program
    {
        static void Main(string[] args)
        { 
            bool flag = true;
           
            while (flag)
            {
                Console.WriteLine("1 for link list");
                Console.WriteLine("2 for stack");
                Console.WriteLine("3 link list node");
                Console.WriteLine("4. Reverse the order");
                Console.WriteLine("Enter The Number");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1: //Linked List
                        Demo demo = new Demo();
                        demo.Check();
                        break;
                    case 2:
                        //stack
                        Stack_Demo stack_demo = new Stack_Demo();
                        stack_demo.Element();
                        break;
                    case 3:
                        LinkList_Demo linklistdemo = new LinkList_Demo();
                        linklistdemo.Add(4);
                        linklistdemo.Add(10);
                        linklistdemo.Add(20);
                        linklistdemo.Display();
                        break;
                     case 4:
                        LinkList_Demo linklist_demo = new LinkList_Demo();
                        linklist_demo.Reverse_Order(33);
                        linklist_demo.Reverse_Order(50);
                        linklist_demo.Reverse_Order(99);
                        linklist_demo.Display();
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }
        }

    }
}
