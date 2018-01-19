// the nth item is the result of counting and saying the n-1 item
public class Solution {
    public string CountAndSay(int n) {
        if(n == 0) return string.Empty;
        if(n == 1) return "1";
        string last = CountAndSay(n - 1);
        int count = 0;
        char say = '1';
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < last.Length; i++){
            if(i == 0){
                count = 1;
                say = last[i];
            }
            else if(last[i] != last[i - 1]){
                sb.Append(count.ToString());
                sb.Append(say);
                count = 1;
                say = last[i];
            }
            else {
                count++;
            }

        }
        sb.Append(count.ToString());
        sb.Append(say);
        return sb.ToString();
    }
}
