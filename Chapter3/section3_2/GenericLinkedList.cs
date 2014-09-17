using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.section3_2
{
    class GenericLinkedList<T>
    {
        private GenericNode<T> m_head;

        public GenericLinkedList()
        {
            m_head = null; 
        }

        public bool isEmpty()
        {
            return m_head == null;
        }

        public T getFront()
        {
            return m_head.element;
        }

        public void addFront(T val)
        {
            GenericNode<T> v = new GenericNode<T>();
            v.element = val;
            v.next = m_head;
            m_head = v;
        }

        public void removeFront()
        {
            GenericNode<T> old = m_head;
            m_head = old.next;
            // OR: m_head = m_head.next;
        }
        public void PrintAllItems()
        {
            if (isEmpty())
            {
                Console.WriteLine("empty list");
                return;
            }
            GenericNode<T> temp = m_head;
            Console.WriteLine("list items are:");
            //print all items in list
            while (temp != null)
            {
                Console.Write(temp.element.ToString() + ",");
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
    
}
