using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.section3_1.section3_1_1
{
    //page 105
    class Scores
    {
        
        GameEntry[] m_Entries;
        int m_maxEntries;
        int m_actualNumEntries;
        public Scores(int max)
        {
            m_maxEntries = max;
            m_Entries = new GameEntry[m_maxEntries];
            m_actualNumEntries = 0;
        }

        public bool add(GameEntry g) 
        { 
            //add items ordered by score
            int nScore = g.m_Score;
            if (m_actualNumEntries < m_maxEntries) //at least 1 available location
            {
                int position = m_actualNumEntries - 1; //last index
                while (position >= 0 && nScore > m_Entries[position].m_Score)
                {
                    m_Entries[position + 1] = m_Entries[position];

                    position--;
                }
                //stops at the correct position for insertion
                m_Entries[position] = g;
                m_actualNumEntries++;
                return true; //done
            }
            else return false;//failed to add
        }

        public GameEntry remove(int i)
        {
            if (i < 0 || i >= m_actualNumEntries)
                return null;
            m_actualNumEntries--;
            int position = i;
            GameEntry result = m_Entries[position];
            while (position <=m_actualNumEntries)
            {
                m_Entries[position] = m_Entries[position + 1]; //shift items
                position++;
            }
            return result;
        }
    }
}
