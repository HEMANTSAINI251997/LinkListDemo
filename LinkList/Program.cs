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
            LinkList_Demo linklistdemo = new LinkList_Demo();
            LinkedListStack linkliststack  = new LinkedListStack();
            bool flag = true;
           
            while (flag)
            {
                Console.WriteLine("1 for link list");
                Console.WriteLine("2 for stack");
                Console.WriteLine("3 link list node");
                Console.WriteLine("4. Reverse the order");
                Console.WriteLine("5. Remove First Node");
                Console.WriteLine("6. Remove Last Node");
                Console.WriteLine("7. CALC Size of Linked List");
                Console.WriteLine("8. Searching the element ");
                Console.WriteLine("9. Insert data in stack");
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
                        
                        linklistdemo.Add(4);
                        linklistdemo.Add(10);
                        linklistdemo.Add(20);
                        linklistdemo.Display();
                        break;
                     case 4:
                       // LinkList_Demo linklist_demo = new LinkList_Demo();
                        linklistdemo.Reverse_Order(33);
                        linklistdemo.Reverse_Order(50);
                        linklistdemo.Reverse_Order(99);
                        linklistdemo.Display();
                        break;
                    case 5:
                      
                        linklistdemo.RemoveFirst();
                        linklistdemo.Display();
                        break;
                    case 6:
                        linklistdemo.RemoveLast();
                        linklistdemo.Display();
                        break;
                    case 7:
                        linklistdemo.LinkeedSize();
                        break;
                    case 8:
                        int val = linklistdemo.Search(10);
                        Console.WriteLine("POSITION = "+ val);
                        break;
                    case 9:
                        linkliststack.Push(55);
                        linkliststack.Push(25);
                        linkliststack.Push(5);
                        Console.WriteLine("...................");
                        linkliststack.Display();
                        Console.WriteLine("...................");
                        linkliststack.Peek();
                        Console.WriteLine("...................");
                        linkliststack.Pop();
                        Console.WriteLine("...................");
                        linkliststack.Display();
                        break;

                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }
        }

    }
}
