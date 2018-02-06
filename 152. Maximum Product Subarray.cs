public class Solution {
    public int MaxProduct(int[] nums) {
        //dp[i] 以 nums[i] 结束的MaxProduct， dp必须定位以i结束，才能保证“连续”这个意义
        int[] minNeg = new int[nums.Length];
        int[] maxPos = new int[nums.Length];
        maxPos[0] = nums[0];
        minNeg[0] = nums[0];
        int max = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] == 0){
                maxPos[i] = 0;
                minNeg[i] = 0;
            }
            // 1. no include i - 1
            // 2. include i - 1 不管正负，先算出来极大极小值
            maxPos[i] = Math.Max(nums[i], Math.Max(nums[i] * maxPos[i - 1], nums[i] * minNeg[i - 1]));
            minNeg[i] = Math.Min(nums[i], Math.Min(nums[i] * maxPos[i - 1], nums[i] * minNeg[i - 1]));
            if(maxPos[i] > max){
                max = maxPos[i];
            }
        }
        return max;
    }
}
