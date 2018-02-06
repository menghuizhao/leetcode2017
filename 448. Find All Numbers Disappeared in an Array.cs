public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> result = new List<int>();
        if(nums == null || nums.Length == 0){
            return result;
        }
        for(int i = 0; i < nums.Length; i++){
            int abs = Math.Abs(nums[i]);
            if(nums[abs - 1] > 0){
                nums[abs - 1] *= -1;
            }
        }
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0){
                result.Add(i + 1);
            }
        }
        return result;
    }
}
