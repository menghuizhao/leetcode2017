public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num == 0) return true;
        long low = 0;
        long high = num / 2 + 1;
        while(low <= high){
            long mid = (low + high) / 2;
            long sq = mid * mid;
            if(sq == num) return true;
            else if(sq < num) low = mid + 1;
            else high = mid - 1;
        }
        return false;//没有正好的
    }
}
// 参考69题
