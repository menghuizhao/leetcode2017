public class Solution {
    public int DistributeCandies(int[] candies) {
        if(candies == null || candies.Length == 0) return 0;
        HashSet<int> kinds = new HashSet<int>();
        for(int i = 0; i < candies.Length; i++){
            if(!kinds.Contains(candies[i])){
                kinds.Add(candies[i]);
            }
        }
        int countKinds = kinds.Count;
        int number = candies.Length / 2;
        if(countKinds <= number){
            return countKinds;
        }
        return number;
    }
}
