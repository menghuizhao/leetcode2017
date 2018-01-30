public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        if(string.IsNullOrEmpty(s)) return 0;
        for(int i = 0; i < s.Length; i++){
            if(i - 1 >= 0 && RToI(s[i]) > RToI(s[i - 1])){
                result += RToI(s[i]) - RToI(s[i - 1]);
                result -= RToI(s[i - 1]); // remove reduntant adding in last loop
            }
            else{
                result += RToI(s[i]);
            }
        }
        return result;

    }
    private int RToI(char c){
        switch(c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
