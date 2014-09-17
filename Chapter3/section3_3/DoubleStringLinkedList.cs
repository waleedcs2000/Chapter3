using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.section3_3
{
    class DoubleStringLinkedList
    {
        private DNode m_head;
        private DNode m_tail;

        public DoubleStringLinkedList()
        {
            m_head = new DNode(); 
            m_tail = new DNode();

            m_head.next = m_tail;
            m_tail.previous = m_head;
        }

        public bool isEmpty()
        {
            return m_head.next == m_tail;
        }

        public string getFront()
        {
            return m_head.next.element;
        }
         public string getBack()
        {
            return m_tail.previous.element;
        }

        public DNode addBefore(DNode v , string newItem )
        {
            DNode u =new DNode();
            u.element = newItem;
            DNode oldPrevious = v.previous;
            
            u.next = v;
            u.previous = oldPrevious;

            v.previous = u;
            oldPrevious.next = u;

            return u;
        }

        public DNode addFront(string val)
        {
           return addBefore(m_head.next,val);
        }
         public DNode addTail(string val)
        {
           return addBefore(m_tail,val);
        }

        public void remove (DNode v)
        {
            DNode oldPrevious = v.previous;
            DNode oldNext = v.next;
            oldPrevious.next = oldNext;
            oldNext.previous = oldPrevious;
                 
        }
        public void removeFront()
        {
           remove(m_head.next);
            // OR: m_head = m_head.next;
        }

        public void removeTail()
        {
            remove(m_tail.previous);
        }

        public void PrintAllItems()
        {
            if (isEmpty())
            {
                Console.WriteLine("empty list");
                return;
            }
            DNode temp = m_head.next;
            Console.WriteLine("list items are:");
            //print all items in list
            while (temp != m_tail)
            {
                Console.Write(temp.element + ",");
                temp = temp.next;
            }
            Console.WriteLine("\ndone");
        }
    
    }
}
