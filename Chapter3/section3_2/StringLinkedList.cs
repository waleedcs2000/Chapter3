using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.section3_2
{
    class StringLinkedList
    {
        private StringNode m_head;

        public StringLinkedList()
        {
            m_head = null; 
        }

        public bool isEmpty()
        {
            return m_head == null;
        }

        public string getFront()
        {
            return m_head.element;
        }

        public void addFront(string val)
        {
            StringNode v = new StringNode();
            v.element = val;
            v.next = m_head;
            m_head = v;
        }

        public void removeFront()
        {
            StringNode old = m_head;
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
            StringNode temp = m_head;
            Console.WriteLine("list items are:");
            //print all items in list
            while (temp != null)
            {
                Console.Write(temp.element + ",");
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
}
