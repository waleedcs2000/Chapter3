using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.section3_4
{
    class CircularList
    {
        public CNode m_cursor;

        public CircularList()
        {
            m_cursor = null;
        }

        public bool isEmpty()
        {
            return m_cursor == null;
        }

        public string back()
        {
            return m_cursor.Elem;
        }

        public string front()
        {
            return m_cursor.Next.Elem;
        }

        public void advance()
        {
            m_cursor = m_cursor.Next;
        }

        public void add(string n)
        {
            CNode v = new CNode();
            v.Elem = n;
            if (isEmpty())
            {
                v.Next = v; //circul with only 1 item
                m_cursor = v;
            }
            else
            {
                v.Next = m_cursor.Next;
                m_cursor.Next = v;
            }
        }

        public void remove()
        {
            CNode old = m_cursor.Next;
            if (m_cursor == old)
                m_cursor = null;
            else
                m_cursor.Next = old.Next;
        }

        

    }
}
