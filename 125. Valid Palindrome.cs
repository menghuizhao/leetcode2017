public class Solution {
    public bool IsPalindrome(string s) {
        if(s == null) return false;
        if(string.Equals(s, string.Empty)) return true;
        char[] arr = s.ToLower().ToCharArray();
        arr = Array.FindAll<char>(arr, c => char.IsLetterOrDigit(c));
        for(int i = 0; i < arr.Length / 2; i++){
            if(arr[i] != arr[arr.Length - 1 - i]) return false;
        }
        return true;
    }
}
