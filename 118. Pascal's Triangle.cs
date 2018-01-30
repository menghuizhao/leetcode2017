public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        if(numRows < 1) return triangle;
        for(int i = 0; i < numRows; i++){
            IList<int> level = new List<int>();
            if(i == 0){
                level.Add(1);
            }
            else{
                var upLevel = triangle[i - 1];
                for(int j = 0; j < upLevel.Count; j++){
                    if(j == 0){
                        level.Add(1);
                    }
                    else{
                        level.Add(upLevel[j] + upLevel[j - 1]);
                    }
                }
                level.Add(1);
            }
            triangle.Add(level);
        }
        return triangle;
    }
}
