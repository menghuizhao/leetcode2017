//Extra space usually means O(n) space. To deal with overflow for fully reversed integer, reverse only half of it
// x = 4224 -> x = 4224 -> 424 -> 42; rev = 0 ->4 -> 42
public class Solution {
    public bool IsPalindrome(int x) {
        if (x == 0) return true;
        if (x < 0 || x % 10 == 0) return false;
        int rev = 0;
        while(x > rev){
            rev = rev * 10 + x % 10;
            x = x / 10;
        }
        return x == rev || x == rev / 10;
    }
}
