public class Solution {
    public void Rotate(int[] nums, int k) {
        if(nums == null || nums.Length == 0) return;
        k = k % nums.Length;
        reverse(nums, 0, nums.Length - k - 1);
        reverse(nums, nums.Length - k, nums.Length - 1);
        reverse(nums, 0, nums.Length - 1);
    }
    private void reverse(int[] nums, int i, int j){
        int tmp = 0;
        while(i < j){
            tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
            i++;
            j--;
        }
    }
}
