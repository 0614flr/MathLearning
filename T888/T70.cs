namespace T888;

//
// 假设你正在爬楼梯。需要 n 阶你才能到达楼顶。
//
// 每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
//
//  
//
// 示例 1：
//
// 输入：n = 2
// 输出：2
// 解释：有两种方法可以爬到楼顶。
// 1. 1 阶 + 1 阶
// 2. 2 阶
// 示例 2：
//
// 输入：n = 3
// 输出：3
// 解释：有三种方法可以爬到楼顶。
// 1. 1 阶 + 1 阶 + 1 阶
// 2. 1 阶 + 2 阶
// 3. 2 阶 + 1 阶
//  
//
// 提示：
//
// 1 <= n <= 45
public class T70
{
    public int ClimbStairs(int n)
    {
        /***
         * 记忆法多路递归
         * 先创建一个memory数组，数字0也要存，大小n+1
         * 0，1层是只有一种方法的情况
         */
        var memory = new int[n + 1];
        memory[0] = 1;
        memory[1] = 1;
        return memorys(n, memory);
    }

    private int memorys(int n, int[] memo)
    {
        if (memo[n] != 0)
            return memo[n];
        var x = memorys(n - 1, memo);
        var y = memorys(n - 2, memo);
        memo[n] = x + y;
        return memo[n];
    }
}
// int climbStairs(int n)
// {
//     int dp[n+2];
//     dp[0] = 1;
//     dp[1] = 1;
//     //dp[2] = dp[0] 两步  + dp[1] 走1步
//     int i;
//     for(i =2; i <= n; i++)
//     {
//         dp[i] = dp[i-1] + dp[i-2];
//     }  
//     return dp[n];
// }
//这个没懂他的逻辑