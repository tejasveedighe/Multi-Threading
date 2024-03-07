using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multi_Threading
{
    internal class ThreadPritorities
    {
        static int count1, count2;
        public static void Test1()
        {
            while (true)
            {
                count1++;
            }
        }
        public static void Test2()
        {
            while (true)
            {
                count2++;
            }
        }
        public static void Main()
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);

            t1.Priority = ThreadPriority.Normal;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.WriteLine("Test1 : " + count1);
            Console.WriteLine("Test2 : " + count2);

        }
    }
}
