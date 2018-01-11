public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length == 0) return 0;
        int dp = 0;
        int min = prices[0];
        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < min){
                min = prices[i];
            }
            //prices[i] > min in the left
            dp = Math.Max(dp, prices[i] - min);
        }
        return dp;
    }
}
