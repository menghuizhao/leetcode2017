public class Solution {
    public int NumJewelsInStones(string J, string S) {
        if(string.IsNullOrEmpty(J) || string.IsNullOrEmpty(S)) return 0;
        int count = 0;
        for(int i = 0; i < S.Length; i++){
            if(J.IndexOf(S[i]) != -1) count++;
        }
        return count;
    }
}
