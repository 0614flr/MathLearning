namespace T888;

// 给定一个由 整数 组成的 非空 数组所表示的非负整数，在该数的基础上加一。
//
// 最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。
//
// 你可以假设除了整数 0 之外，这个整数不会以零开头。
//
//  
//
// 示例 1：
//
// 输入：digits = [1,2,3]
// 输出：[1,2,4]
// 解释：输入数组表示数字 123。
// 示例 2：
//
// 输入：digits = [4,3,2,1]
// 输出：[4,3,2,2]
// 解释：输入数组表示数字 4321。
// 示例 3：
//
// 输入：digits = [0]
// 输出：[1]
//  
//
// 提示：
//
// 1 <= digits.length <= 100
// 0 <= digits[i] <= 9
//参考答案
// public int[] plusOne(int[] digits) {
//     for (int i = digits.length - 1; i >= 0; i--) {
//         if (digits[i] == 9) {
//             digits[i] = 0;
//         } else {
//             digits[i] += 1;
//             return digits;
//         }
//
//     }
//     //如果所有位都是进位，则长度+1
//     digits= new int[digits.length + 1];
//     digits[0] = 1;
//     return digits;
// }
public class T66
{
    public int[] PlusOne(int[] digits)
    {
        /***
         * 输入一个int类型数组，如{1，2，3}我首先考率的是将之转化为字符串123
         * 再将字符串转化为int类型数字123，对数字直接进行+1，再转换为字符串，子串串数组，最后变成int类型数组
         * 参考答案解法是直接遍历
         * 9加一变为0，前一位加一，以此类推
         */
        for (var i = digits.Length - 1; i >= 0; i--)
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] += 1;
                return digits;
            }

        digits = new int[digits.Length + 1];
        digits[0] = 1;
        return digits;
    }
}