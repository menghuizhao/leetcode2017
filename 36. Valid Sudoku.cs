//row[9][9]: row[x][y] 在第x行是否已经出现了y
public class Solution {
    public bool IsValidSudoku(char[,] board) {
        if(board == null || board.Length == 0) return false;
        bool[,] row = new bool[9,9];
        bool[,] col = new bool[9,9];
        bool[,] sub = new bool[9,9]; //sub block
        for(int i = 0; i < board.GetLength(0); i++){
            for(int j = 0; j < board.GetLength(1); j++){
                if(board[i, j] == '.'){
                    continue;
                }
                int index = (int)(board[i, j] - '1');
                // Calculate which row/col/block it belongs, row = i, col = j
                int subBlockIndex = i / 3 * 3 + j / 3;
                if(row[i, index] || col[j, index] || sub[subBlockIndex, index]){
                    return false;
                }
                row[i, index] = true;
                col[j, index] = true;
                sub[subBlockIndex, index] = true;
            }
        }
        return true;
    }
}
