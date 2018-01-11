public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length < 1) return 0;
        int newLength = 1;
        int temp = nums[0];
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > temp){
                temp = nums[i];
                newLength++;
                nums[newLength - 1] = nums[i];
            }
        }
        return newLength;
    }
}
