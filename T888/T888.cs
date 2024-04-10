namespace T888;

// 爱丽丝和鲍勃拥有不同总数量的糖果。给你两个数组 aliceSizes 和 bobSizes ，aliceSizes[i] 是爱丽丝拥有的第 i 盒糖果中的糖果数量，bobSizes[j] 是鲍勃拥有的第 j 盒糖果中的糖果数量。
//
// 两人想要互相交换一盒糖果，这样在交换之后，他们就可以拥有相同总数量的糖果。一个人拥有的糖果总数量是他们每盒糖果数量的总和。
//
// 返回一个整数数组 answer，其中 answer[0] 是爱丽丝必须交换的糖果盒中的糖果的数目，answer[1] 是鲍勃必须交换的糖果盒中的糖果的数目。如果存在多个答案，你可以返回其中 任何一个 。
// 题目测试用例保证存在与输入对应的答案。
//A{1,2,34,3}
//数组排序是nlogn
//.sort=>数组排序优于嵌套循环
// 示例 1：
// azong -bzong=c=>ai-bj=c=>ai-c=bj=>
// 输入：aliceSizes = [1,1], bobSizes = [2,2]
// 输出：[1,2]
// 示例 2：
//
// 输入：aliceSizes = [1,2], bobSizes = [2,3]
// 输出：[1,2]
// 示例 3：
//
// 输入：aliceSizes = [2], bobSizes = [1,3]
// 输出：[2,3]
// 示例 4：
//
// 输入：aliceSizes = [1,2,5], bobSizes = [2,4]
// 输出：[5,4]
public class T888
{
    public int[] FairCandySwap(int[] A, int[] B)
    {
        int sumA = 0, sumB = 0;
        var ans = new int[2];
        foreach (var item in A) sumA += item;
        foreach (var item in B) sumB += item;
        Array.Sort(A);
        Array.Sort(B);
        int i = 0, j = 0;
        while (i < A.Length && j < B.Length)
        {
            if (sumA - sumB == 2 * (A[i] - B[j]))
            {
                ans[0] = A[i];
                ans[1] = B[j];
                return ans;
            }

            if (sumA - A[i] + B[j] >= sumB - B[j] + A[i])
                i++;
            else
                j++;
        }

        return ans;
    }
}
//先数组排序
//取a最大位，b最小位
//用双指针
//aliceSizes = [1,2,5], bobSizes = [2,4]
//