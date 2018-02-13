public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        IList<int> result = new List<int>();
        for(int i = left; i <= right; i++){
            if(helper(i)){
                result.Add(i);
            }
        }
        return result;
    }
    private bool helper(int i){
        int remain = i;
        while(remain > 0){
            int divisor = remain % 10;
            remain = remain / 10;
            if(divisor == 0){
                return false;
            }
            if(i % divisor != 0){
                return false;
            }
        }
        return true;
    }
}
