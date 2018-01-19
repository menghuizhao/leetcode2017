public class Solution {
    public void Rotate(int[,] matrix) {
        if(matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
        int n = matrix.GetLength(0);
        //up-down flip, iterate row 0 ~ [n/2] - 1
        for(int i = 0; i < n / 2; i++){
            //swap row i with row n - 1 - i
            for(int j = 0; j < n; j++){
                int temp = matrix[i, j];
                matrix[i, j] = matrix[n - 1 - i, j];
                matrix[n - 1 - i, j] = temp;
            }
        }
        // flip symmetrically by leftup - bottomright
        for(int i = 0; i < n; i++){
            //swap [i,j] with [j,i]
            for(int j = i + 1; j < n; j++){
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
        return;
    }
}
