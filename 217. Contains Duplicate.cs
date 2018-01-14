public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums == null || nums.Length == 0) return false;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 1; i++){
            if(nums[i] == nums[i + 1]) return true;
        }
        return false;
    }
}
