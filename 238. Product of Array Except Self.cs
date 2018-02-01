// result[i] = Mul(1 ~ i- 1) * Mul(i + 1 ~ n)
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(nums == null || nums.Length == 0) return new int[0];
        int[] result = Enumerable.Repeat(1, nums.Length).ToArray();
        int factor = 1;
        for(int i = 0; i < nums.Length; i++){
            result[i] *= factor;
            factor *= nums[i];
        }
        factor = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            result[i] *= factor;
            factor *= nums[i];
        }
        return result;
    }
}
