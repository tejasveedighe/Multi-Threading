using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threading
{
    internal class ThreadJoin
    {
        public static void Test()
        {
            Console.WriteLine("Start of test1");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }
            Thread.Sleep(5000);
            Console.WriteLine("End of test1");
        }
        public static void Test2()
        {
            Console.WriteLine("Start of test2");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of test2");
        }
        public static void Test3()
        {
            Console.WriteLine("Start of test3");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of test3");
        }
        public static void Main()
        {
            Console.WriteLine("Start of Main Thread");
            Thread t1 = new Thread(Test);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(3000); t2.Join(); t3.Join();

            Console.WriteLine("End of Main Thread");
        }
    }
}
