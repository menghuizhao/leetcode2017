// 1. DP, O（n^2)

public class Solution {
    public int Jump(int[] nums) {
        if(nums == null || nums.Length < 1) return -1;
        int[] steps = new int[nums.Length];
        steps[0] = 0; //just for corner case [0]
        for(int i = 1; i < nums.Length; i++) {
            steps[i] = Int32.MaxValue;
        }
        for(int i = 1; i < nums.Length; i++){
            for(int j = 0; j < i; j++){
                if (j + nums[j] >= i) {
                    steps[i] = Math.Min(steps[i], steps[j] + 1);
                }
            }
        }
        return steps[nums.Length - 1];
    }
}

//2. Greedy

public class Solution {
    public int Jump(int[] nums) {
        if(nums == null || nums.Length < 1) return -1;

        int start = 0;
        int end = 0;

        int jumps = 0;
        // Make a trial for one jump
        while(end < nums.Length - 1) { //题目说reach last index，所以当end = length - 1的时候不在需要跳
            jumps++;
            int farthest = end;
            //从上一个while探知到的最远处开始向右继续搜索
            for(int i = start; i <= end; i++) {
                if(nums[i] + i > farthest){
                    farthest = nums[i] + i;
                }
            }
            //1.start是上一次搜索中能达到的最远处，end是这个while中刚刚更新的最远处
            start = end + 1;
            end = farthest;
        }
        return jumps;
    }
}
