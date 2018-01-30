public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        uint iterator = 1;
        int loop = 1;
        while(loop <= 32){
            if((iterator & n) == iterator){
                count++;
            }
            iterator *= 2;
            loop++;
        }
        return count;
    }
}
