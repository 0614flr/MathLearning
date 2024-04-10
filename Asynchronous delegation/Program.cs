internal class MyClass
{
    private static void DownloadFile(object filepath)
    {
        Console.WriteLine("开始下载" + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        Console.WriteLine("下载完成");
    }

    public static void Main(string[] args)
    {
        var t = new Thread(DownloadFile); //创建出来Thread对象但是没有启动
        t.IsBackground = true; //设置为后台线程
        t.Start("xxx种子"); //开始执行线程
        Console.WriteLine("Main");
        t.Join(); //让当前线程睡眠，等待t执行完在运行之后的代码
    }
}