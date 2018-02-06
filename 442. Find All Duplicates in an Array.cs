public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        IList<int> result = new List<int>();
        if(nums == null || nums.Length == 0){
            return result;
        }
        for(int i = 0; i < nums.Length; i++){
            int abs = Math.Abs(nums[i]);
            if(nums[abs - 1] > 0){
                nums[abs - 1] *= -1;
            }
            else{
                result.Add(abs);
            }
        }
        return result;
    }
}
