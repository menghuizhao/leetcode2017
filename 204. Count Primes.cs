// LESS than n
public class Solution {
    public int CountPrimes(int n) {
        if(n <= 2) return 0;
        int count = n - 1;
        bool[] isPrime = Enumerable.Repeat(true, n + 1).ToArray();
        isPrime[1] = false;
        count--;
        for(int i = 2; i < n + 1; i++){
            if( i * i >= n){
                break;
            }
            if(isPrime[i]){
                int j = i;
                while( i * j < n){
                    if(isPrime[i * j]){ // avoid count-- repeatly
                        isPrime[i * j] = false;
                        count--;
                    }

                    j++;
                }
            }
        }
        return count;
    }
}
