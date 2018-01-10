//借鉴 300 最长递增子序列的动归
public class Solution {
    public int WiggleMaxLength(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        int[] subDpA = new int[nums.Length]; // longest length of wiggle seq ending with i, but requires nums[i] > previous element
        int[] subDpB = new int[nums.Length]; // longest length of wiggle seq ending with i, but requires nums[i] < previous element
        // init, single element is regarded as wiggle
        for(int i = 0; i < nums.Length; i++){
            subDpA[i] = 1;
            subDpB[i] = 1;
        }
        int maxLength = 1;
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < i; j++){
                // if 右大于左, 要取 左大于右 的那个数组subB来比较， 而不是subA
                if(nums[i] > nums[j]){
                    subDpA[i] = Math.Max(subDpA[i], subDpB[j] + 1);
                    if(subDpA[i] > maxLength){
                        maxLength = subDpA[i];
                    }
                }
                if(nums[i] < nums[j]){
                    subDpB[i] = Math.Max(subDpB[i], subDpA[j] + 1);
                    if(subDpB[i] > maxLength){
                        maxLength = subDpB[i];
                    }
                }
            }
        }
        return maxLength;
    }
}
//贪心O(n)
//因为wiggle只要求右边和左边比较，前面的元素大小不用再考虑， 所以dp 做了过多的比较
//而递增子序列要求前面元素的大小还要小于当前元素，所以不能贪心
//维护 p 和 q， p是subdpA[]从左到右遍历能达到的最大长度
//如果右大于左， 则 p = q + 1, (q此时的值一定有一个序列满足)
public int WiggleMaxLength(int[] nums)
{
    if(nums == null || nums.Length == 0) return 0;
    int p = 1, q = 1, n = nums.Length;
    for (int i = 1; i < n; ++i) {
        if (nums[i] > nums[i - 1]) p = q + 1;
        else if (nums[i] < nums[i - 1]) q = p + 1;
    }
    return Math.Max(p, q);
}
