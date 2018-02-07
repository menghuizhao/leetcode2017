// 1. TLE
public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        HashSet<int> hs = new HashSet<int>();
        int min = nums[0];
        int max = nums[0];
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] < min){
                min = nums[i];
            }
            if(nums[i] > max){
                max = nums[i];
            }
            if(!hs.Contains(nums[i])){
                hs.Add(nums[i]);
            }
        }
        int consecutiveCount = 1;
        int maxCount = 1;
        foreach(int key in hs.ToList()){
            consecutiveCount = 1;
            int i = 1;
            while(hs.Contains(key - i)){
                i++;
                consecutiveCount++;
            }
            i = 1;
            while(hs.Contains(key + i)){
                i++;
                consecutiveCount++;
            }
            if(consecutiveCount > maxCount){
                maxCount = consecutiveCount;
            }
        }
        return maxCount;
    }
}
//2.
//https://aaronice.gitbooks.io/lintcode/content/data_structure/longest_consecutive_sequence.html
//对于每一个n，
// 检查是否为一个consecutive sequence的边界，也就是n-1不存在于set中，再逐次检查n + 1, n + 2, n + 3...是否在set中，最终得到另一个上边界（+1）m，
// 所以sequence的长度为m - n （也可以是n+1不存在于set中，则反向检查）。转为set，时间O(n)，之后对于set中的每一个元素，
// 如果是一个连续序列的下边界，则对这个连续序列进行，因为对于每一个连续序列实际只会扫描一遍，所以这个循环最终是O(n)时间复杂度的。
public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        HashSet<int> hs = new HashSet<int>();
        int min = nums[0];
        int max = nums[0];
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] < min){
                min = nums[i];
            }
            if(nums[i] > max){
                max = nums[i];
            }
            if(!hs.Contains(nums[i])){
                hs.Add(nums[i]);
            }
        }
        int consecutiveCount = 1;
        int maxCount = 1;
        foreach(int key in hs.ToList()){
            consecutiveCount = 1;
            if(!hs.Contains(key - 1)){
                int i = 1;
                while(hs.Contains(key + i)){
                    consecutiveCount++;
                    i++;
                }
                maxCount = Math.Max(maxCount, consecutiveCount);
            }
        }
        return maxCount;
    }
}
