public class Solution {
    public bool IsAnagram(string s, string t) {
        if(string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) return true;
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return false;
        Dictionary<char, int> d1 = MakeDict(s);
        Dictionary<char, int> d2 = MakeDict(t);
        return CompareDict(d1, d2);
    }
    private Dictionary<char, int> MakeDict(string s){
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(dict.ContainsKey(s[i])){
                dict[s[i]]++;
            }
            else{
                dict[s[i]] = 1;
            }
        }
        return dict;
    }
    private bool CompareDict(Dictionary<char, int> d1, Dictionary<char, int> d2){
        if(d1.Count != d2.Count) return false;
        foreach(var kv in d1){
            if(!d2.ContainsKey(kv.Key) || d2[kv.Key] != kv.Value){
                return false;
            }
        }
        return true;

    }
}
