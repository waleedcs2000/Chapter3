using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.section3_1.section3_1_1
{
    class GameEntry
    {
        private String name ="";
        private int score = 0;

        public int m_Score { get; set; }
        public String  m_Name { get; set; }

        public GameEntry(String N, int s )
        {
            m_Score = s;
            m_Name = N;
        }
    }
}
