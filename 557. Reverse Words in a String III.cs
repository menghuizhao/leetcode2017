public class Solution {
    public string ReverseWords(string s) {
        if(string.IsNullOrEmpty(s)) return string.Empty;
        StringBuilder sb = new StringBuilder();
        string[] split = s.Split(' ');
        for(int i = 0; i < split.Length; i++){
            var charArr = split[i].ToCharArray();
            Array.Reverse(charArr);
            var reversed = (new string(charArr)).Trim();
            sb.Append(reversed + " ");
        }
        return sb.ToString().Trim();
    }
}
