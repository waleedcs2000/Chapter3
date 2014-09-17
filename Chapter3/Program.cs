using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter3.section3_1.section3_1_1;
using Chapter3.section3_1.section3_1_2;
using Chapter3.section3_2;
using Chapter3.section3_3;
using Chapter3.section3_4;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------
            #region test section 3.1.1
            ////test section 3.1.1 (NOT WORKING WELL, it causes errors iin run time)
            //Scores scores = new Scores(3);
            //GameEntry g1= new GameEntry("a", 1),
            //    g2= new GameEntry("b", 2),
            //    g3 = new GameEntry("c", 3),
            //    g4 = new GameEntry("d",4);

            ////add in wrong order
            //bool done = scores.add(g2);
            //Console.WriteLine("done:"+done);
            
            //done = scores.add(g1);
            //Console.WriteLine("done:" + done);

            //done = scores.add(g4);
            //Console.WriteLine("done:" + done);
            
            //done = scores.add(g3);
            //Console.WriteLine("done:" + done);

            ////remove 2nd item
            //GameEntry removed = scores.remove(1);
            //Console.WriteLine("removed item is:" + removed.m_Name);
            //-----------------------end of secrion 3.1.1
            #endregion //test section 3.1.1

            #region test section 3.1.2

            ////sample array, note the character casing is treated as different characters
            //char[] sample_insertion = { 'b', 'a', 'x', 'n', 'A', 'Z' };
            //InsertionSortClass.InsertionSort(sample_insertion);
            //InsertionSortClass.PrintCharArray(sample_insertion, "insert sort result:");
            //#endregion //end section 3.1.2

            //#region section 3.2 string linked list
            //StringLinkedList stringLinkList = new StringLinkedList();
            //stringLinkList.addFront("welcome");
            //stringLinkList.addFront("all");
            //stringLinkList.addFront("in");
            //stringLinkList.addFront("mansoura");

            //stringLinkList.PrintAllItems();
            //stringLinkList.removeFront();
            //stringLinkList.removeFront();
            //stringLinkList.removeFront();
            //stringLinkList.removeFront();

            //stringLinkList.PrintAllItems();

            #endregion //section 3.2 string linked list

            #region section Generic linked list

            //GenericLinkedList<string> generalList = new GenericLinkedList<string>();
            //generalList.addFront("welcome");
            //generalList.addFront("all");
            //generalList.addFront("in");
            //generalList.addFront("mansoura");

            //generalList.PrintAllItems();
            //generalList.removeFront();
            //generalList.removeFront();
            //generalList.removeFront();
            //generalList.removeFront();

            //generalList.PrintAllItems();

           
            #endregion //section generic linked list

            #region section 3.3 double linked list
            //DoubleStringLinkedList dlist = new DoubleStringLinkedList();
            //DNode a = dlist.addFront("A");
            //DNode b = dlist.addFront("b");
            //dlist.addFront("c");
            //dlist.addTail("d");
            //dlist.remove(a);
            //dlist.PrintAllItems();
            #endregion //double linked list

            #region section 3.4
            //CircularList circlist = new CircularList();
            //circlist.add("a");
            //circlist.add("b");
            //circlist.add("c");

            //Console.WriteLine(circlist.front());
            //circlist.advance();
            //Console.WriteLine(circlist.front());
            //circlist.advance();
            //Console.WriteLine(circlist.front());

            //circlist.remove();
            //Console.WriteLine(circlist.front());
            #endregion
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }

    }
}
