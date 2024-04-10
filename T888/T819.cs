﻿using System.Text;

namespace T888;

// 给你一个字符串 paragraph 和一个表示禁用词的字符串数组 banned ，返回出现频率最高的非禁用词。题目数据 保证 至少存在一个非禁用词，且答案 唯一 。
//
// paragraph 中的单词 不区分大小写 ，答案应以 小写 形式返回。
//
//  
//
// 示例 1：
//
// 输入：paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
// 输出："ball"
// 解释：
// "hit" 出现了 3 次，但它是禁用词。
// "ball" 出现了两次（没有其他单词出现这么多次），因此它是段落中出现频率最高的非禁用词。
// 请注意，段落中的单词不区分大小写，
// 标点符号会被忽略（即使它们紧挨着单词，如 "ball,"），
// 并且尽管 "hit" 出现的次数更多，但它不能作为答案，因为它是禁用词。
// 示例 2：
//
// 输入：paragraph = "a.", banned = []
// 输出："a"
//  
//
// 提示：
//
// 1 <= paragraph.length <= 1000
// paragraph 由英文字母、空格 ' '、和以下符号组成："!?',;."
// 0 <= banned.length <= 100
// 1 <= banned[i].length <= 10
// banned[i] 仅由小写英文字母组成
public class T819
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        string Maxword;
        ISet<string> bannedSet = new HashSet<string>();
        foreach (var word in banned) bannedSet.Add(word);

        var maxFrequency = 0;
        var frequencies = new Dictionary<string, int>();
        var sb = new StringBuilder();
        var length = paragraph.Length;
        for (var i = 0; i <= length; i++)
            if (i < length && char.IsLetter(paragraph[i]))
            {
                sb.Append(char.ToLower(paragraph[i]));
            }
            else if (sb.Length > 0)
            {
                var word = sb.ToString();
                if (!bannedSet.Contains(word))
                {
                    if (!frequencies.ContainsKey(word))
                        frequencies.Add(word, 1);
                    else
                        frequencies[word]++;

                    maxFrequency = Math.Max(maxFrequency, frequencies[word]);
                }

                sb.Length = 0;
            }

        var mostCommon = "";
        foreach (var pair in frequencies)
        {
            var word = pair.Key;
            var frequency = pair.Value;
            if (frequency == maxFrequency)
            {
                mostCommon = word;
                break;
            }
        }

        return mostCommon;
    }
}