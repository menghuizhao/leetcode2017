public class NumArray {

    private int[] nums { get; set; }

    private int[] sums { get; set; } // sums[i] = nums[0] + ... nums[i]

    public NumArray(int[] nums) {
        this.nums = nums;
        if(nums == null) return;
        if(nums.Length < 1) {
            this.nums = new int[0];
            this.sums = new int[0];
        }
        this.sums = new int[nums.Length];
        int accu = 0;
        for(int i = 0; i < nums.Length; i++) {
            accu += nums[i];
            sums[i] = accu;
        }
    }

    public int SumRange(int i, int j) {
        if(i <= 0){
            return sums[j];
        }
        return sums[j] - sums[i - 1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */
