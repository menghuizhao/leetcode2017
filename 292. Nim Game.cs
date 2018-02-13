public class Solution {
    public bool CanWinNim(int n) {
        if(n <= 3) return true;
        bool[] dp = new bool[n];
        dp[0] = true;
        dp[1] = true;
        dp[2] = true;
        for(int i = 3; i < n; i++){
            if(dp[i - 1] && dp [i - 2] && dp[i - 3]){
                dp[i] = false;
            }
            else{
                dp[i] = true;
            }
        }
        return dp[n - 1];
    }
}
public class Solution {
    public bool CanWinNim(int n) {
        if(n <= 3) return true;

        return n % 4 != 0;
    }
}
