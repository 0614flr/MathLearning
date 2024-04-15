namespace TimeKeeper;

public class Timer
{
    public int N { get; set; }

    /***
     * 时常为n的倒计时
     */
    public void TimeAlarmClockMenu()
    {
        Console.WriteLine("请输入倒计时时长（秒）：");
        if (int.TryParse(Console.ReadLine(), out var n))
            N = n;
        else
            Console.WriteLine("输入无效的整数值。");
        var thread = new Thread(TimedAlarmClock);
        thread.IsBackground = true;
        thread.Start();
    }

    public void TimedAlarmClock()
    {
        Console.WriteLine("计时开始" + N + "s");
        Thread.Sleep(N * 1000);
        Console.WriteLine("计时结束");
    }

    public void LocalTimeAlamClockMenu()
    {
        Console.WriteLine("请输入倒计时时长（秒）：");
        if (int.TryParse(Console.ReadLine(), out var n))
            N = n;
        else
            Console.WriteLine("输入无效的整数值。");
        var thread = new Thread(LocalTimeAlamClock);
        thread.IsBackground = true;
        thread.Start();
    }

    public void LocalTimeAlamClock()
    {
        Console.WriteLine("现在时间是");
        var currentTime = DateTime.Now;
        Console.WriteLine("当前系统时间：" + currentTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("将在" + N + "s" + "之后呼叫您");
        Thread.Sleep(N * 1000);
        Console.WriteLine("当前系统时间：" + currentTime.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}