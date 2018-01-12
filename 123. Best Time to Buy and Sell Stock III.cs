// dp + Divide and Conquer
// profit = leftMaxProfit[0~i] + rightMaxProfit[i ~ n-1]
// i只是分界点，并不一定是卖出并买入的点，卖出也不一定就买入
// dp是从i = 0~n找profit最大值
// 求 leftMaxProfit[k] = 动归， max(left[k-1], prices[k]-min),min在从左往右扫描的时候记录
// 求 rightMaxProfit[k] = 也是动归但是要从右往左扫，因为不能扫到左边0~k的值。所以从左往右求right[k]需要扫第k~第n-1个元素，把所有rightMax[k]都求出来的话这一步就变O(n2)了
// 但是从右往左求right就是O(n)
// Time = O(n)
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length == 0) return 0;
        // Left part (0 ~ i) max Profit
        int[] left = new int[prices.Length];
        // Right part (i ~ n-1) max Profit
        int[] right = new int[prices.Length];
        // min value when scanning from left to right
        int min = prices[0];
        // max value when scanning from right to left
        int max = prices[prices.Length - 1];
        // Scanning from left to right
        left[0] = 0;
        for(int i = 1; i < prices.Length; i++){
            min = Math.Min(min, prices[i]);
            left[i] = Math.Max(left[i - 1], prices[i] - min);
        }
        // Scanning from right to left
        right[prices.Length - 1] = 0;
        for(int i = prices.Length - 2; i >= 0; i--){
            max = Math.Max(max, prices[i]);
            right[i] = Math.Max(right[i + 1], max - prices[i]);
        }
        // iterate all i, get max profit
        int profit = 0;
        for(int i = 0; i < prices.Length; i++){
            profit = Math.Max(profit, left[i] + right[i]);
        }
        return profit;
    }
}
