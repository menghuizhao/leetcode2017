public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0) return new int[0];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        // Load map
        for(int i = 0; i < nums1.Length; i++){
            if(dict.ContainsKey(nums1[i])){
                dict[nums1[i]] ++;
            }
            else{
                dict[nums1[i]] = 1;
            }
        }
        List<int> inter = new List<int>();
        //
        for(int i = 0; i < nums2.Length; i++){
            if(dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0){
                inter.Add(nums2[i]);
                dict[nums2[i]] --;
            }
        }
        return inter.ToArray();
    }
}
