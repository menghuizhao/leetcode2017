public class Solution {
    public int Rob(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        int max = Int32.MinValue;
        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        for(int i = 0; i < nums.Length; i++){
            if(i == 0){
                dp[0] = nums[0];
            }
            else if(i == 1){
                dp[1] = nums[1];
            }
            else if(i - 3 < 0){
                dp[i] = dp[i - 2] + nums[i];
            }
            else { // 要在 i - 3 和 i - 2 之间选一个大的
                dp[i] = Math.Max(dp[i - 3], dp[i - 2]) + nums[i];
            }
            if(dp[i] > max){
                max = dp[i];
            }
        }
        return max;
    }
}
