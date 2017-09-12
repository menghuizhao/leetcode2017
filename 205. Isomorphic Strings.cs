public class Solution {
    public bool IsIsomorphic(string s, string t) {
        //Boring corner case: "" and "" is true
        if(string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)){
            return true;
        }
        //make sure valid string + same length
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length){
            return false;
        }
        Dictionary<char, char> dict = new Dictionary<char, char>();
        for(int i = 0; i < s.Length; i ++){
            if(dict.ContainsKey(s[i])){
                if(t[i] != dict[s[i]]){
                    return false;
                }
            }
            else{
                if(dict.ContainsValue(t[i])){
                    return false;
                }
                dict.Add(s[i], t[i]);
            }
        }
        return true;
    }
}
