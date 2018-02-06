//swap
//当要求O(n)不能回头看的时候可以使用此方法将数字放在正确位置上
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(nums == null || nums.Length == 0){
            return 1;
        }
        for(int i = 0; i < nums.Length; i++){
            while(nums[i] >= 1 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i]){
                int val = nums[i];
                int index = val - 1;
                int temp = nums[index];
                nums[index] = val;
                nums[i] = temp;
            }
        }
        for(int i = 0; i < nums.Length; i++){
           if(nums[i] != i + 1) return i + 1;
       }
        return nums.Length + 1;
    }
}
