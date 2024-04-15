namespace T888;

// 编写一个函数来查找字符串数组中的最长公共前缀。
//
// 如果不存在公共前缀，返回空字符串 ""。
//
//  
//
// 示例 1：
//
// 输入：strs = ["flower","flow","flight"]
// 输出："fl"
// 示例 2：
//
// 输入：strs = ["dog","racecar","car"]
// 输出：""
// 解释：输入不存在公共前缀。
//  
//
// 提示：
//
// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] 仅由小写英文字母组成
public class T14
{
    public string LongestCommonPrefix(string[] strs)
    {
        var i = 0;
        var j = 0;
        char[] l = { };
        var a = new List<char[]>();
        foreach (var str in strs)
        {
            a[i] = str.ToCharArray();
            i++;
        }

        for (i = 0; i <= a[0].Length; i++)
        for (j = 1; j <= a.Count; j++)
        {
            foreach (var x in a[j])
                if (a[0][i] == x)
                {
                    l[i] = x;
                    break;
                }
                else
                {
                    l[i] = Convert.ToChar("");
                    break;
                }

            break;
        }

        var st = string.Join("", l);
        return st;
    }
}