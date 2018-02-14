//1. TLE  结合 367题
public class Solution {
    public bool JudgeSquareSum(int c) {
        if(c == 0) return true;
        for(long i = 0; i * i * 2 <= c; i++){
            if(IsPerfectSquare(c - i * i)){
                return true;
            }
        }
        return false;
    }
    // question 367
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

//2.用sqrt
public class Solution {
    public bool JudgeSquareSum(int c) {
        if(c == 0) return true;
        double d = (double)c;
        for(long i = 0; i * i <= c; i++){
            if(i * i == c){
                return true;
            }
            long sub = c - i * i;
            double sq = Math.Sqrt((double)sub);
            if(sq == (int)sq){
                return true;
            }
        }
        return false;
    }
}
