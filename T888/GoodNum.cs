namespace T888;
/***
 * 通常个，百，万等数位为单数，十，万，十万等数位为偶数的数的数称为“好数”，给一个数，如何判断他是不是好数
 *
 */

public class GoodNum
{
    public bool GoodNumber(int n)
    {
        var numberStr = n.ToString();
        var digits = numberStr.ToCharArray();

        if (digits.Length % 2 != 0)
        {
            Console.WriteLine("不是好数");
            return false;
        }

        for (var i = 1; i < digits.Length; i += 2)
            if (Convert.ToInt32(digits[i]) % 2 == 0)
            {
                Console.WriteLine("不是好数");
                return false;
            }

        Console.WriteLine("是好数");
        return true;
    }
}