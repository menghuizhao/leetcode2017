public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        // dp[i]以i为结尾必须包含i，能得到的 最大和
        int max = Int32.MinValue;
        int[] dp = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(i == 0){//init
                dp[i] = nums[i];
            }
            //状态方程， 如果dp[i - 1]是负数，就舍弃 i-1 前面所有
            else if(dp[i - 1] < 0){
                dp[i] = nums[i];
            }
            //如果dp[i - 1]是正数，因为dp[i]必须包括nums[i]，所以直接相加
            else{
                dp[i] = dp[i - 1] + nums[i];
            }
            if(dp[i] > max){
                max = dp[i];
            }
        }
        return max;
    }
}
