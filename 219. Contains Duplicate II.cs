//O(n2) will get TLE
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums == null || nums.Length == 0) return false;
        for(int i = 0; i < nums.Length - 1; i++){
            for(int j = i + 1; j < nums.Length && j <= i + k; j++)
            {
                if(nums[i] == nums[j]) return true;
            }
        }
        return false;
    }
}
// Use extra space, dict, key is num value, value is num index
// Time = O(n) Space = O(n)
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums == null || nums.Length == 0) return false;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        //left to right
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                if(Math.Abs(i - dict[nums[i]]) <= k){
                     return true;
                }
                else{
                    dict[nums[i]] = i; // update index to use the new one
                }
            }
            else{
                dict[nums[i]] = i;
            }
        }
        return false;
    }
}
