public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums == null || nums.Length == 0) return;
        int insertIndex = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != 0){
                nums[insertIndex++] = nums[i];
            }
        }
        for(int i = insertIndex; i < nums.Length; i++){
            nums[i] = 0;
        }
    }
}
