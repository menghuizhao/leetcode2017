// Fisher-Yates Algorithm https://leetcode.com/problems/shuffle-an-array/solution/ 

public class Solution {
    private int[] reset { get; set; }
    private int[] nums { get; set; }
    private Random rand { get; set; }

    public Solution(int[] nums) {
        this.reset = (int[])nums.Clone();
        this.nums = (int[])nums.Clone();
        this.rand = new Random();
    }

    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        return this.reset;
    }

    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        for(int i = 0; i < nums.Length; i++){
            Swap(i, this.randRange(i, nums.Length));
        }
        return this.nums;
    }

    private void Swap(int a, int b){
        int temp = this.nums[a];
        this.nums[a] = this.nums[b];
        this.nums[b] = temp;
    }

    private int randRange(int min, int max) {
        return rand.Next(max - min) + min;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
