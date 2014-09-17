using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3.section3_1.section3_1_2
{
    class InsertionSortClass
    {
        public static void InsertionSort(char[] items)
        {
            int n = items.Length;
            for (int i = 1; i < n; i++)
            { 
                char current = items[i];
                int j = i - 1;
                while((j>=0) && (items[j]> current))
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = current;
            }
        }
        public static void PrintCharArray(char[] items,string message)
        {
            Console.WriteLine(message);
            foreach (char i in items)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
