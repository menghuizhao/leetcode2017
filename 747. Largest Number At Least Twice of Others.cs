public class Solution {
    public int DominantIndex(int[] nums) {
        if(nums == null || nums.Length < 1) return -1;
        if(nums.Length == 1) return 0;
        int maxIndex = 0;
        int biggest = 0;//0 is the min possible value by the problem description
        int second = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > biggest){
                second = biggest;
                biggest = nums[i];
                maxIndex = i;
            }
            else if(nums[i] == biggest){
                // there is exactly one largest element
                // if code enters here, nums[i] and biggest will not be the biggest finally
            }
            else if(nums[i] > second){
                second = nums[i];
            }
        }
        if(second * 2 <= biggest){
            return maxIndex;
        }
        else{
            return -1;
        }
    }
}
