public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        if(
            A == null || A.Length == 0 ||
            B == null || B.Length == 0 ||
            C == null || C.Length == 0 ||
            D == null || D.Length == 0
        )
        return 0;
        int count = 0;
        Dictionary<int, int> abDict = new Dictionary<int, int>(); // key: sum, value: count
        Dictionary<int, int> cdDict = new Dictionary<int, int>();
        for(int i = 0; i < A.Length; i++){
            for(int j = 0; j < B.Length; j++){
                int key = A[i] + B[j];
                if(!abDict.ContainsKey(key)){
                    abDict[key] = 1;
                }
                else{
                    abDict[key] += 1;
                }
            }
        }
        for(int i = 0; i < C.Length; i++){
            for(int j = 0; j < D.Length; j++){
                int key = C[i] + D[j];
                if(abDict.ContainsKey(0 - key)){
                    count += abDict[0 - key];
                }
            }
        }
        return count;
    }
}
