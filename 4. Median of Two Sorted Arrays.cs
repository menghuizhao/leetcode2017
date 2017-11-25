public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        if((m + n) % 2 == 1){
            return (double)FindKthLargest(nums1, m, nums2, n, (m + n) / 2 + 1);
        }
        return (FindKthLargest(nums1, m, nums2, n, (m + n) / 2) + FindKthLargest(nums1, m, nums2, n, (m + n) / 2 + 1)) / 2;
    }
    public double FindKthLargest(int[] a, int m, int[] b, int n, int k){
        if(m > n){
            return FindKthLargest(b, n, a, m, k);
        }
        if(m == 0){
            return b[k - 1];
        }
        if(k == 1){
            return Math.Min(a[0], b[0]);
        }
        //Divide k into two parts
        int pa = Math.Min(m, k / 2);
        int pb = k - pa;
        if(a[pa - 1] < b[pb - 1]){
            int[] subArray = new int[m - pa];
            Array.Copy(a, pa, subArray, 0, m- pa);
            return FindKthLargest(subArray, m - pa, b, n, k - pa);
        }
        else if (a[pa - 1] > b[pb - 1]){
            int[] subArray = new int[n - pb];
            Array.Copy(b, pb, subArray, 0, n - pb);
            return FindKthLargest(a, m , subArray, n - pb, k - pb);
        }
        return a[pa - 1];
    }
}
