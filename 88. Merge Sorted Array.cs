public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(nums1 == null || nums2 == null) return;
        int p = m + n - 1;
        int p1 = m - 1;
        int p2 = n - 1;
        while(p1 >= 0 && p2 >= 0){
            if(nums1[p1] >= nums2[p2]){
                nums1[p--] = nums1[p1--];
            }
            else{
                nums1[p--] = nums2[p2--];
            }
        }
        //if run out nums2, done, num1 don't need to change
        //if run out nums1
        while(p2 >= 0){
            nums1[p--] = nums2[p2--];
        }
        return;
    }
}
