public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        IList<int> list = new List<int>();
        if(matrix == null || matrix.Length == 0) return list;
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        //bound
        int upper = 0; int right = n - 1; int bot = m - 1; int left = 0;
        //right, down, left, up. go forever
        while(true){
            //going right
            for(int i = left; i <= right; i++ ){
                //i'm at upper bound
                list.Add(matrix[upper, i]);
            }
            upper++;// done with current upper bound
            //before going down, check if upper bound is conflicted with bottom bound
            if(upper > bot) break;
            // going down
            for(int i = upper; i <= bot; i++){
                //im' at right bound
                list.Add(matrix[i, right]);
            }
            right--; // done with current right bound
            //before going left, check if right bound meets left bound
            if(right <  left) break;
            //going left
            for(int i = right; i >= left; i--){
                //im' at bottom bound
                list.Add(matrix[bot, i]);
            }
            bot--; // bot bound move up
            //before going up, check if bot bound meets upper bound
            if(bot < upper ) break;
            //going up
            for(int i = bot; i >= upper; i--){
                //im' at left bound
                list.Add(matrix[i, left]);
            }
            left++; // bot bound move up
            //before going , check if bot bound meets upper bound
            if(left > right) break;
        }
        return list;
    }
}
