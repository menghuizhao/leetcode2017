public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        int slow = 0, fast = 0, dupCount = 0, dupVal = 0, validLength = 0;

        while(fast < nums.Length) {
            if(fast >= 1  //no need to check index 0
               &&
               nums[fast] == nums[fast - 1]) // find a duplicate
            {
                dupVal = nums[fast]; // set duplicate value
                dupCount += 1;
                // if reaches duplicate limit, pause the slow pointer here. Keep moving forward the fast pointer until you find a new value.
                if(dupCount == 2){
                    while(fast < nums.Length){
                        if(nums[fast] != dupVal){ // got a new value
                            dupCount = 0;
                            break;
                        }
                        else{
                            fast++;
                        }
                    }
                    if(fast == nums.Length){ // didn't find a new value yet, but fast pointer already reaches the tail
                        return validLength;
                    }
                }

            }
            else { // not a duplicate, reset dup counter
                dupCount = 0;
            }

            nums[slow++] = nums[fast++];
            validLength++; //only a copy action can trigger the increase of final length
        }
        return validLength;
    }
}
