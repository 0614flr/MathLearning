internal class MyClass
{
    private static void ThreadMethod(object state)
    {
        Console.WriteLine("start" + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        Console.WriteLine("End");
    }

    public static void Main(string[] args)
    {
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        ThreadPool.QueueUserWorkItem(ThreadMethod);
        Console.ReadKey();
    }
}