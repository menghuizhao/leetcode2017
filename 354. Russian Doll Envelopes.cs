// 排序以后的最长子序列问题
// 最长子序列用300题解法
// 排序信封：按w从小到大，w相等时候h从大到小
// 然后按h的序列计算最长子序列
// 因为w从小到大排好了所以宽度一定能套上，h排成右边比左边小保证 w左 <= w右的时候是套不上的，不会计算错误
public class Solution {
    // Envelope class
    public class Envelope
    {
        public int w { get; set; }
        public int h { get; set; }
    }
    // Envelope comparer
    public class EnvelopeComparer : IComparer<Envelope>
    {
        public int Compare(Envelope x, Envelope y)
        {
            if (x.w < y.w) return -1;
            if (x.w > y.w) return 1;
            if (x.h < y.h) return 1;
            if (x.h > y.h) return -1;
            return 0;
        }
    }
    // Main Entry
    public int MaxEnvelopes(int[,] envelopes)
    {
        // Corner case
        if (envelopes == null || envelopes.Length == 0) return 0;
        //Convert 2-dimension array to List of Envelope
        List<Envelope> envList = new List<Envelope>();
        int numOfEnvelopes = envelopes.Length / 2;
        for (int i = 0; i < numOfEnvelopes; i++)
        {
            envList.Add(new Envelope
            {
                w = envelopes[i, 0],
                h = envelopes[i, 1]
            });
        }
        // Sort envelope array using comparer
        Envelope[] envArray = envList.ToArray();
        Array.Sort(envArray, new EnvelopeComparer());
        // Caluate LIS of heights array
        int[] heightsArr = envArray.Select(k => k.h).ToArray();
        return LengthOfLIS(heightsArr);
    }
    // leetcode 300
    public int LengthOfLIS(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;
        // dp: dp[i] = LengthofLIS ending at index I
        int[] dp = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i] = 1;
        }
        int maxDp = dp[0];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                    if (dp[i] > maxDp)
                    {
                        maxDp = dp[i];
                    }
                }
            }
        }
        return maxDp;
    }
}
