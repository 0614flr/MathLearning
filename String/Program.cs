internal class MyClass
{
    public static void Main(string[] args)
    {
        var a = Test;
        var ar = a.BeginInvoke(100, "sike", OnCallBack, null);
    }

    private static int Test(int i, string str)
    {
        Console.WriteLine(i + str);
        return 100;
    }

    private static void OnCallBack(IAsyncResult ar)
    {
        Console.WriteLine("子线程结束");
    }
}