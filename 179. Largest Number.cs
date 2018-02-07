public class Solution {
    public string LargestNumber(int[] nums) {
        if(nums == null || nums.Length == 0) return string.Empty;
        Array.Sort(nums, new AComparer());
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < nums.Length; i++){
            sb.Append(nums[i].ToString());
        }
        return TrimZero(sb.ToString());
    }
    //[0,0,0,...,0] -> "000000000" -> "0"
    private string TrimZero(string s){
        int countHeadingZero = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '0'){
                countHeadingZero++;
            }
            else{
                break;
            }
        }
        if(s.Remove(0, countHeadingZero) == string.Empty){
            return "0";
        }
        return s.Remove(0, countHeadingZero);
    }
    public class AComparer : IComparer<int>
    {
       // Call CaseInsensitiveComparer.Compare with the parameters reversed.
       public int Compare(int x, int y)
       {
           long xy = Int64.Parse(x.ToString() + y.ToString());
           long yx = Int64.Parse(y.ToString() + x.ToString());
           if(xy - yx > 0){
               return -1;
           }
           if(xy - yx < 0){
               return 1;
           }
           return 0;
       }
    }
}
