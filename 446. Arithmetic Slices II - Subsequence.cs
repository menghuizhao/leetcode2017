public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        if(A == null || A.Length < 3){
          return 0;
        }
        int total = 0;
        Dictionary<int, Dictionary<long, int>> dict = new Dictionary<int, Dictionary<long, int>>();
        for(int i = 0; i < A.Length; i++){
            Dictionary<long, int> endWithKeyDiffWithVal = new Dictionary<long, int>();
            dict.Add(i, endWithKeyDiffWithVal); // initialize
            for(int j = 0; j < i; j++){
                if((long)A[i] - (long)A[j] > Int32.MaxValue || (long)A[i] - (long)A[j] < Int32.MinValue){
                    continue;
                }
                int count1 = 0; // end with A[j], difference is diff
                long diff = (long)A[i] - (long)A[j];
                if(dict[j].ContainsKey(diff)){
                    count1 = dict[j][diff];
                }

                int count2 = 0; // end with A[i], difference is diff
                if(dict[i].ContainsKey(diff)){
                    count2 = dict[i][diff];
                }
                dict[i][diff] = count2 //accumlate those generates by previous "j"s
                                + count1 // # of arithmetic generated by this "j"
                                + 1; // 1st = a[j], 2nd = a[i], wait for 3rd =
                                //note that we have a "1" here, this 1 is not accumulated to total,
                                //when we find the 3rd number, this 1 will be in count1, and then accumlated to total as 1 arithmetic
                                //so this is correct

                total += count1;
            }
        }
        return total;
    }
}