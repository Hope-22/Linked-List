using System;
using System.Collections.Generic;
using System.Text;

// form our node, that consist of data and next
namespace Linked_List
{
    public class Node<T>
    {

    
        public T data;
        public Node<T> next;

        public Node(T value)
        {
            data = value;
            next = null;
        }
    
    }
}
