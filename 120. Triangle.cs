public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        //f(0) = 0
        if(triangle == null || triangle.Count <= 0){
            return 0;
        }
        //f(1) = 1
        if(triangle.Count == 1){
            return triangle[0][0];
        }
        
        int n = triangle.Count;
        int[] current_row_min = new int[n];
        int[] last_row_min = new int[n];
        last_row_min[0] = triangle[0][0];
        for(int level = 2; level <= n; level++){
            for(int col = 1; col <= level; col ++){
                if(col == 1){
                    current_row_min[col - 1] = last_row_min[col - 1] + triangle[level - 1][col - 1];
                }
                else if(col < level){
                    current_row_min[col - 1] = Math.Min(last_row_min[col - 2], last_row_min[col - 1]) + triangle[level - 1][col - 1];
                }
                else{
                    current_row_min[col - 1] = last_row_min[col - 2] + triangle[level - 1][col - 1];
                }
                if(col - 2 >= 0) {
                    last_row_min[col - 2] = current_row_min[col - 2]; //cache last row result
                }
                if(col == level){
                    last_row_min[col - 1] = current_row_min[col - 1];
                }

            }
        }
        int temp_min = current_row_min[0];
        for(int col = 1; col <= n; col++){
            temp_min = Math.Min(temp_min, current_row_min[col - 1]);
        }
        return temp_min;
    }
}
