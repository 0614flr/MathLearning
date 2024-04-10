using System.Text;

namespace T888;

// 给你两个二进制字符串 a 和 b ，以二进制字符串的形式返回它们的和。
// 示例 1：
//
// 输入:a = "11", b = "1"
// 输出："100"
// 示例 2：
//
// 输入：a = "1010", b = "1011"
// 输出："10101"
//  
//
// 提示：
//
// 1 <= a.length, b.length <= 104
// a 和 b 仅由字符 '0' 或 '1' 组成
//     字符串如果不是 "0" ，就不含前导零
public class T67
{
    public string AddBinary(string a, string b)
    {
        a = new string(a.ToCharArray().Reverse().ToArray());
        b = new string(b.ToCharArray().Reverse().ToArray());
        var str = new StringBuilder();
        string res;
        var bit = 0;
        for (var i = 0; i < Math.Max(a.Length, b.Length); i++)
            if (i >= a.Length)
            {
                AddBinary(b[i], '0', out res, ref bit);
                str.Append(res);
            }
            else if (i >= b.Length)
            {
                AddBinary(a[i], '0', out res, ref bit);
                str.Append(res);
            }
            else
            {
                AddBinary(a[i], b[i], out res, ref bit);
                str.Append(res);
            }

        if (bit == 1)
            str.Append("1");
        return new string(str.ToString().ToCharArray().Reverse().ToArray());
    }

    private void AddBinary(char x, char y, out string res, ref int bit)
    {
        var sum = x - '0' + y - '0' + bit;
        if (sum > 2)
        {
            res = "1";
            bit = 1;
        }
        else if (sum > 1)
        {
            res = "0";
            bit = 1;
        }
        else
        {
            res = sum.ToString();
            bit = 0;
        }
    }
}