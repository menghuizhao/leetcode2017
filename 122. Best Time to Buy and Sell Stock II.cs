//O(n)， 只算上升，一下降就卖
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length == 0) return 0;
        int profit = 0;
        int buyin = prices[0];
        for(int i = 1; i < prices.Length; i++){
            if(prices[i] > prices[i - 1]){
                profit += prices[i] - prices[i - 1];
            }
        }
        return profit;
    }
}
