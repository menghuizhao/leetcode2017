//1. int问题要用long防止溢出
//2. x 的 平方根不可能大于 x / 2，用 0 ~ x / 2 + 1进行二分法，否则TLE
public class Solution {
    public int MySqrt(int x) {
        if(x == 0) return 0;
        long low = 0;
        long high = x / 2 + 1;
        while(low <= high){
            long mid = (low + high) / 2;
            long sq = mid * mid;
            if(sq == x) return Convert.ToInt32(mid);
            else if(sq < x) low = mid + 1;
            else high = mid - 1;
        }
        return Convert.ToInt32(high);//没有正好的
    }
}
