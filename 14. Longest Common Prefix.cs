public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0) return string.Empty;
        StringBuilder common = new StringBuilder("");
        int i = 0;
        while(true){
            char check = Char.MinValue;//reset
            for(int k = 0; k < strs.Length; k++){
                string str = strs[k];
                if(str.Length - 1 < i){
                    return common.ToString();
                }
                if(k == 0){
                    check = str[i];//init
                }
                if(str[i] != check) {
                    return common.ToString();
                }
            }
            common.Append(check);
            i++;
        }
        return common.ToString();
    }
}
