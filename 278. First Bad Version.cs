/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;
        int bad = -1;
        while(left <= right){
            int mid = left + (right - left) / 2; // use left + right / 2 may cause integer overflow for large integer test case
            if(IsBadVersion(mid)){
                right = mid - 1;
                bad = mid;
            }
            else{
                left = mid + 1;
            }

        }
        return bad;
    }
}
