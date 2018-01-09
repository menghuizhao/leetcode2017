public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle)) return 0;
        if(string.IsNullOrEmpty(needle)) return 0;// ????
        if(string.IsNullOrEmpty(haystack)) return -1;
        bool match = false;
        for(int i = 0; i < haystack.Length; i++){
            match = true;
            if(i + needle.Length > haystack.Length) break;
            for(int j = 0; j < needle.Length && i + j < haystack.Length; j++){
                if(haystack[i + j] != needle[j]){
                    match = false;
                    break;
                }
            }
            if(match) return i;
        }
        return -1;
    }
}
