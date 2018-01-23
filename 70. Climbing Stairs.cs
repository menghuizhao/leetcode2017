public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) return n;
        int[] dp = new int[n];
        dp[0] = 1;// n = 1
        dp[1] = 2;// n = 2
        // 方法 = 差1梯迈一步 和 差2梯迈两步，所以是dp [n-1] + dp[n-2] 不是dp [n-1] + 1 + dp[n-2] + 2
        for(int i = 2; i < n; i++){
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        return dp[n - 1];
    }
}
