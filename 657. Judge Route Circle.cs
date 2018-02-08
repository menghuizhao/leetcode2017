public class Solution {
    public bool JudgeCircle(string moves) {
        if(string.IsNullOrEmpty(moves)) return true;
        int[] counts = new int[4];
        counts[0] = 0;
        counts[1] = 0;
        counts[2] = 0;
        counts[3] = 0;
        for(int i = 0; i < moves.Length; i++){
            if(moves[i] == 'U'){
                counts[0]++;
            }
            if(moves[i] == 'D'){
                counts[1]++;
            }
            if(moves[i] == 'L'){
                counts[2]++;
            }
            if(moves[i] == 'R'){
                counts[3]++;
            }
        }
        return counts[0] == counts[1] && counts[2] == counts[3];
    }
}
