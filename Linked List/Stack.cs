using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class StackWithLinkedList<T>
    
        {
            Node<T> top;
            public StackWithLinkedList()
            {
                this.top = null;
            }
            public void Push(T x)   
            // At the head, linkedlist for stack; will have the top node,
            // and the tails will have bottom node.
        {
                // create a new node temp and allocate memory
                Node<T> temp = new Node<T>(x);
                if (top == null)
                {
                    temp.next = null;
                }
                else
                {
                    temp.next = top;
                }
                top = temp;
            }
            // Utility function to check if
            // the stack is empty or not
            public bool IsEmpty()
            {
                return top == null;
            }

            // Utility function to return
            // top element in a stack
            public T Peek()
            {
                // check for empty stack
                if (!IsEmpty())
                {
                    return top.data;
                }
                else
                {
                    Console.WriteLine("Stack is empty");
                    return default;
                }
            }
            
            public void Pop() //removes the last iem
        {
                // check for stack underflow 
                if (top == null)
                {
                    Console.Write("\nStack Underflow");
                    return;
                }
                // returns the last iem
                top = top.next;
                Console.WriteLine(top.data);
            }
            public int Size()
            {
                Node<T> current = top;
                if (current == null)
                {
                    return 0;
                }
                int counter = 1;
                while (current.next != null)
                {
                    current = current.next;
                    counter++;
                }
                return counter;
            }
            public void PrintNode()
            {
                Node<T> current = top;
                while (current != null)
                {
                    Console.WriteLine("Value of a Node is {0}", current.data);
                    current = current.next;
                }
            }
        }
    }
