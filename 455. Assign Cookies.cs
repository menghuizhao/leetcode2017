public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        //ATTENTION: at most one cookie per child.
        int counter = 0;
        if(g == null || s == null || g.Length < 1 || s.Length < 1) return 0;
        // Descending sort
        Array.Sort<int>(g);
        Array.Reverse(g);
        Array.Sort<int>(s);
        Array.Reverse(s);

        int childPointer = 0;
        int cookiePointer = 0;
        while(childPointer < g.Length && cookiePointer < s.Length) {
            if(s[cookiePointer] >= g[childPointer]){
                counter++;
                childPointer++;
                cookiePointer++;
            }
            else{
                childPointer++;
            }
        }
        return counter;
    }
}
