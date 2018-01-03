public class Solution {
    public string ReverseString(string s) {
      if(string.IsNullOrEmpty(s)) return s;
      char[] ret = s.ToCharArray();
      for(int i = 0; i < s.Length / 2; i++) {
        var temp = s[s.Length - 1 -i];
        ret[s.Length - 1 -i] = s[i];
        ret[i] = temp;
      }
      return new String(ret);
    }
}
// Note:
//string[index] is read-only
//TLE issue. need to use char array and swap to go for O(n/2) instead of O(n)
