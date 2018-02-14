// == count of 5 + count of 25 + count of 125 ..
public class Solution {
    public int TrailingZeroes(int n) {
        if(n < 5) return 0; // 0! = 1
        int count = 0;
        while(n > 0){
            count += n / 5;
            n = n / 5;
        }
        return count;
    }
}
