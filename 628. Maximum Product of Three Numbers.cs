public class Solution {
    public int MaximumProduct(int[] nums) {
        // 2 neg + 1 positive or 3 positive
        Array.Sort(nums);
        return Math.Max(nums[0] * nums[1] * nums[nums.Length - 1], nums[nums.Length - 3] * nums[nums.Length - 2] * nums[nums.Length - 1]);
    }
}
