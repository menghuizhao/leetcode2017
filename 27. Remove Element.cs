public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums == null || nums.Length == 0) return 0;
        int p1 = 0;
        int p2 = 0;
        while(p1 < nums.Length){
            if(val != nums[p1]){
                nums[p2] = nums[p1];
                p2++;
            }
            p1++;
        }
        return p2;
    }
}
