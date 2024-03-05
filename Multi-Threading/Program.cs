namespace Multi_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Tejasvee's Thread";

            Console.WriteLine(Thread.CurrentThread.Name + " is going to sleep for 5 seconds");
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.Name + " just woke up.");

        }
    }
}
