// 首先看303题的方法用O(n)记录sums数组即sums[i] = nums[0] + ... + nums[i]
// sum[j] - sums[i - 1]就是是以nums[]数组里面位置i到位置j的区间和
// Divide and Conquer
// 最终区间个数和 = 左半个nums[] 里面的区间数 + 右半个nums[] 里面的区间数 + 跨左右的区间数
// 把右边的区间和数组 sums[] 排序，
//
// http://blog.csdn.net/qq508618087/article/details/51435944
// 在右边数组找到两个边界, 设为m, n, 其中m是在右边数组中第一个使得sum[m] - sum[i] >= lower的位置,
// n是第一个使得sum[n] - sum[i] > upper的位置, 这样n-m就是与左边元素i所构成的位于[lower, upper]范围的区间个数.
// 因为左右两边都是已经有序的, 这样可以避免不必要的比较.
//
// 而且因为拍序的是sums数组而不是nums，所以排序完右边的还在右边， 所以这个区间一定是存在的并且是左跨右。
// js解法
// https://github.com/hanzichi/leetcode/blob/master/Algorithms/Count%20of%20Range%20Sum/count-of-range-sum.js

C++ 内含 inplace_merge
class Solution {
public:
   int mergeSort(vector<long>& sum, int lower, int upper, int low, int high)
    {
        if(high-low <= 1) return 0;
        int mid = (low+high)/2, m = mid, n = mid, count =0;
        count = mergeSort(sum,lower,upper,low,mid) + mergeSort(sum,lower,upper,mid,high);
        for(int i =low; i< mid; i++)
        {
            while(m < high && sum[m] - sum[i] < lower) m++;
            while(n < high && sum[n] - sum[i] <= upper) n++;
            count += n - m;
        }
        inplace_merge(sum.begin()+low, sum.begin()+mid, sum.begin()+high);
        return count;
    }

    int countRangeSum(vector<int>& nums, int lower, int upper) {
        int len = nums.size();
        vector<long> sum(len + 1, 0);
        for(int i =0; i< len; i++) sum[i+1] = sum[i]+nums[i];
        return mergeSort(sum, lower, upper, 0, len+1);
    }
};

// C# 未通过，应该是merge sort 有问题， 未调试
//
// public class Solution {
//     public int CountRangeSum(int[] nums, int lower, int upper) {
//         if(nums == null || nums.Length < 1) return 0;
//         int sums[] = new int[nums.Length];
//         // Load sums
//         int accu = 0;
//         for(int i = 0; i < nums.Length; i ++){
//             accu += nums[i];
//             sums[i] = accu;
//         }
//         // count of range
//         int count += Helper(sums, 0, nums.Length, lower, upper);
//         return count;
//     }
//     public List<int> mergeSort(int[] arr, int lower, int upper){
//         if(arr?.Length == 1) return arr;
//         int mid = arr.Length / 2;
//         int[] leftArr = new int[mid];
//         int[] rightArr = new int[arr.Length - mid];
//         Array.Copy(arr, 0, leftArr, 0, mid);
//         Array.Copy(arr, mid, rightArr, 0, arr.Length - mid);
//         return merge(mergeSort(leftArr.ToList(), lower, upper), mergeSort(rightArr.ToList(), lower, upper), lower, upper);
//     }
//     public List<int> merge(List<int> arr1, List<int> arr2, int lower, int upper){
//         count += getAns(left, right, lower, upper);
//         var tmp = new List<int>();
//
//         while (arr1.Count && arr2.Count) {
//             if (arr1[0] < arr2[0])
//               tmp.Add(arr1[0]);
//               arr1.RemoveAt(0);
//             else
//               tmp.Add(arr2[0]);
//               arr2.RemoveAt(0);
//           }
//           return tmp.Concat(arr1).Concat(arr2);
//     }
//     public int getAns(List<int> l1, List<int> l2, int lower, int upper){
//         var sum = 0;
//         var len1 = l1.Count;
//         var len2 = l2.Count;
//
//         var start = 0;
//         var end = 0;
//
//         for (var i = 0; i < len2; i++) {
//
//           // to get start
//           while (l2[i] - l1[start] >= lower) {
//             start++;
//           }
//
//           // to get end
//           while (l2[i] - l1[end] > upper) {
//             end++;
//           }
//
//           sum += start - end;
//         }
//
//         return sum;
//     }
// }
