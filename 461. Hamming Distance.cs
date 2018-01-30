public class Solution {
    public int HammingDistance(int x, int y) {
        return HammingWeight(x ^ y);
    }
    //Question 191
    public int HammingWeight(int n) {
        int count = 0;
        int iterator = 1;
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
