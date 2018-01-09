//O(n2) http://www.cnblogs.com/liyukuneed/archive/2013/05/26/3090402.html
public class Solution {
    public int LengthOfLIS(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        // dp: dp[i] = LengthofLIS ending at index I
        int[] dp = new int[nums.Length];
        for(int i = 0; i < nums.Length; i ++ ) {
            dp[i] = 1;
        }
        int maxDp = dp[0];
        for(int i = 0; i < nums.Length; i ++){
            for(int j = 0; j < i; j++){
                if(nums[j] < nums[i]){
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                    if(dp[i] > maxDp){
                        maxDp = dp[i];
                    }
                }
            }
        }
        return maxDp;
    }
}
