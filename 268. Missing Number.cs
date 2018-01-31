public class Solution {
    public int MissingNumber(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        int sum = 0;
        int numsSum = 0;
        for(int i = 1; i <= nums.Length; i++){
            sum += i;
            numsSum += nums[i - 1];
        }
        return sum - numsSum;
    }
}
