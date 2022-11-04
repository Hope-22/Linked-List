using System;

namespace Linked_List
{ 
    class Program
    {

        static void Main(string[] args)
        {

            QueueLinkedList<int> z = new QueueLinkedList<int>();
            //z.AddToTail(1);
            //z.PrintNode();
            z.Enqueue(1);
            z.Enqueue(2);
            z.Enqueue(3);
           // z.Dequeue();
            //z.Pop();
            //z.Peek();
            Console.WriteLine(z.Size());
                
              
        }
    }       
}

