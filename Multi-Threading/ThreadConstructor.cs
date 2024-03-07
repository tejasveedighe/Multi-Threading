using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threading
{
    internal class ThreadConstructor
    {
        public static void Test1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Test2(object limit)
        {
            int max = Convert.ToInt32(limit);
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(Test1);
            Thread t1 = new Thread(() => { Test1(); });
            Thread t2 = new Thread(delegate () { Test1(); });

            ThreadStart tstart = Test1; // no paramterized delegate
            Thread t3 = new Thread(tstart);

            ParameterizedThreadStart pStart = new ParameterizedThreadStart(Test2); // paramterized thread delegate but only takes object as params
            Thread t4 = new Thread(pStart);
            t4.Start(45);
        }
    }
}
