namespace TimeKeeper;

public class Menu
{
    private char ch;

    public void TimerMenu(char ch)
    {
        var timer = new Timer();
        switch (ch)
        {
            case '1':
                timer.TimeAlarmClockMenu();
                break;
            case '2':
                timer.LocalTimeAlamClockMenu();
                break;
            default:
                Console.WriteLine("111");
                break;
        }
    }
}