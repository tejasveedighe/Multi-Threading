using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threading
{
    internal class ThreadLocking
    {
        public void Display()
        {
            Console.Write("Starting of code block");
            Thread.Sleep(5000);
            Console.WriteLine(" End of code Block");
        }
        public void Display1()
        {
            // only one thread can run this code at one time.
            lock (this)
            {
                Console.Write("Starting of locked code block");
                Thread.Sleep(5000);
                Console.WriteLine(" End of locked code Block");
            }
        }
        static void Main()
        {
            ThreadLocking t = new ThreadLocking();
            Console.WriteLine("\nStart of normal execution");
            t.Display();
            t.Display();
            Console.WriteLine("End of normal execution");

            Thread t0 = new Thread(t.Display);
            Thread t01 = new Thread(t.Display);
            Console.WriteLine("\nStart of multi-thread execution without locking");
            t0.Start();
            t01.Start();
            Console.WriteLine("End of multi-thread execution without locking");

            Console.WriteLine("\nStart of multi-thread execution with locking");
            Thread t1 = new Thread(t.Display1);
            Thread t2 = new Thread(t.Display1);
            Console.WriteLine("End of multi-thread execution with locking");
            t1.Start();
            t2.Start();
        }
    }
}
