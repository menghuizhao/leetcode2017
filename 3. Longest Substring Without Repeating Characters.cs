public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        int maxLength = 1;
        int tempLength = 1;
        //key: character, value: first index at string
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(i == 0){
                dict[s[0]] = 0;
            }
            for(int j = i + 1; j < s.Length; j++){
                //condition: 1. has duplicate char
                //2. duplicate char in range [i,j]
                if(dict.ContainsKey(s[j]) && dict[s[j]] >= i && dict[s[j]] < j){

                    i = dict[s[j]];
                    dict[s[j]] = j;
                    break;
                }
                else{
                    dict[s[j]] = j;
                    tempLength = j - i + 1;
                    if(tempLength > maxLength){
                        maxLength = tempLength;
                    }
                }
            }
        }
        return maxLength;
    }
}
