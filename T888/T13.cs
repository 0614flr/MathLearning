namespace T888;

// 罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。
//
// 字符          数值
// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000
// 例如， 罗马数字 2 写做 II ，即为两个并列的 1 。12 写做 XII ，即为 X + II 。 27 写做  XXVII, 即为 XX + V + II 。
//
// 通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：
//
// I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
// X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。 
// C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。
// 给定一个罗马数字，将其转换成整数。
//
//  
//
// 示例 1:
//
// 输入: s = "III"
// 输出: 3
// 示例 2:
//
// 输入: s = "IV"
// 输出: 4
// 示例 3:
//
// 输入: s = "IX"
// 输出: 9
// 示例 4:
//
// 输入: s = "LVIII"
// 输出: 58
// 解释: L = 50, V= 5, III = 3.
//     示例 5:
//
// 输入: s = "MCMXCIV"
// 输出: 1994
// 解释: M = 1000, CM = 900, XC = 90, IV = 4.
//  
//
//     提示：
//
// 1 <= s.length <= 15
// s 仅含字符 ('I', 'V', 'X', 'L', 'C', 'D', 'M')
// 题目数据保证 s 是一个有效的罗马数字，且表示整数在范围 [1, 3999] 内
//     题目所给测试用例皆符合罗马数字书写规则，不会出现跨位等情况。
// IL 和 IM 这样的例子并不符合题目要求，49 应该写作 XLIX，999 应该写作 CMXCIX 。
// 关于罗马数字的详尽书写规则，可以参考 罗马数字 - Mathematics 。
public class T13
{
    /***
     * 关于本题，我有一些拙见：
     * ivxlcdm是罗马数字，其中
     * I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
     * X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。
     * C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。
     * 在扫描到ixc的时候，是否可以进行一个判断判断其前后的字母是什么
     * emmmmm
     * 太复杂了，
     * 那如果是倒叙遍历呢
     * 只要I不在最右，那就是其他的总数减去i
     * 再简单点就是每个对应一个数
     * 从右往左读，如果左边的数小于等于右边的数则总数--，反之则加上数对应的值
     *
     */
    public int RomanToInt(string s)
    {
        var sum = 0;
        var ss = new List<char>(s.ToCharArray());
        for (var j = 0; j <= ss.Count; j++)
            if (Read(ss[j]) >= ss[j + 1])
                sum = sum + Read(ss[j]);
            else
                sum = sum - Read(ss[j]);

        return sum;
    }

    private int Read(char i)
    {
        var a = 0;
        switch (i)
        {
            case 'I':
                a = 1;
                break;
            case 'V':
                a = 5;
                break;
            case 'X':
                a = 10;
                break;
            case 'L':
                a = 50;
                break;
            case 'C':
                a = 100;
                break;
            case 'D':
                a = 500;
                break;
            case 'M':
                a = 1000;
                break;
            default:
                Console.WriteLine("没有这个字符");
                break;
        }

        return a;
    }
}
// public class Solution {
//     Dictionary<char, int> symbolValues = new Dictionary<char, int> {
//         {'I', 1},
//         {'V', 5},
//         {'X', 10},
//         {'L', 50},
//         {'C', 100},
//         {'D', 500},
//         {'M', 1000},
//     };
//
//     public int RomanToInt(string s) {
//         int ans = 0;
//         int n = s.Length;
//         for (int i = 0; i < n; ++i) {
//             int value = symbolValues[s[i]];
//             if (i < n - 1 && value < symbolValues[s[i + 1]]) {
//                 ans -= value;
//             } else {
//                 ans += value;
//             }
//         }
//         return ans;
//     }
// }
//
// 作者：力扣官方题解
// 链接：https://leetcode.cn/problems/roman-to-integer/solutions/774992/luo-ma-shu-zi-zhuan-zheng-shu-by-leetcod-w55p/
// 来源：力扣（LeetCode）
// 著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。