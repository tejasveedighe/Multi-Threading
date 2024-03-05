namespace Multi_Threading
{
    internal class Program
    {
        static void Threads(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Tejasvee's Thread";

            Console.WriteLine(Thread.CurrentThread.Name + " is going to sleep for 5 seconds");
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.Name + " just woke up.");
        }

        public static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 1: " + i);
            }
            Console.WriteLine("Test1 Ended");
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 2: " + i);
            }
            Console.WriteLine("Test2 Ended");
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 3: " + i);
            }
            Console.WriteLine("Test3 Ended");
        }
        static void Main()
        {
            // normally calling the functions
            // they execute one by one
            Test1();
            Test2();
            Test3();

            Console.WriteLine("Main thread execution ended");
            Console.ReadLine();
            Console.Clear();

            // using threads
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            Console.WriteLine("Using multiple threads");
            t1.Start(); t2.Start(); t3.Start();
        }
    }
}
