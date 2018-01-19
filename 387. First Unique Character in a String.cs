public class Solution {
    public int FirstUniqChar(string s) {
        if(string.IsNullOrEmpty(s)) return -1;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(!dict.ContainsKey(s[i])){
                dict[s[i]] = i;
            }
            else{
                dict[s[i]] = -1;
            }
        }
        int index = s.Length;
        foreach(var kv in dict){
            if(kv.Value > -1 && kv.Value < index){
                index = kv.Value;
            }
        }
        return index == s.Length ? -1 : index;
    }
}
