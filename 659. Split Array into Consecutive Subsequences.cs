public class Solution {
    public bool IsPossible(int[] nums) {
        if(nums == null || nums.Length < 1) return false;
        List<int> ends = new List<int>();
        bool[] indexMarkAsDelete = new bool[nums.Length];//false by default
        //First round get out all 3-in-a-row
        for(int i = 0; i + 2 < nums.Length; i++){
            if(indexMarkAsDelete[i]) continue;// already taken
            // find if there is already a tail that you can append to
            bool hasAvailableTail = false;
            for(int j = 0; j < ends.Count; j++){
                if(ends[j] + 1 == nums[i]) {//can append
                    indexMarkAsDelete[i] = true;
                    ends[j] += 1; // new tail
                    hasAvailableTail = true;
                    break;
                }
            }
            if(hasAvailableTail) continue;
            int first = i;
            int? second = IndexOfNextConsecutive(nums, first, indexMarkAsDelete);
            if(!second.HasValue){// not consecutive
                continue;
            }
            else if(second.Value == nums.Length){ // array end, and the following elements are equal (= nums[first])
                break;
            }
            else {
                int? third = IndexOfNextConsecutive(nums, second.Value, indexMarkAsDelete);
                if(!third.HasValue){// not consecutive
                    continue;
                }
                else if(third.Value == nums.Length){ // array end, and the following elements are equal (= nums[second])
                    break;
                }
                else{//Found 3 consecutive elements
                    //Record this is already used
                    indexMarkAsDelete[first] = true;
                    indexMarkAsDelete[second.Value] = true;
                    indexMarkAsDelete[third.Value] = true;
                    //Record the tail
                    ends.Add(nums[third.Value]);
                }
            }
        }
        //see if anyone can be the 4th/5th/.. element of existing rows
        for(int i = 0; i < nums.Length; i++){
            if(indexMarkAsDelete[i]) continue;// already taken
            for(int j = 0; j < ends.Count; j++){
                if(ends[j] + 1 == nums[i]) {//can append
                    indexMarkAsDelete[i] = true;
                    ends[j] += 1; // new tail
                    break;
                }
            }
        }
        //Check if all elements are in use
        for(int i = 0; i < indexMarkAsDelete.Length; i++){
            if(!indexMarkAsDelete[i]) return false;
        }
        return true;
    }

    public int? IndexOfNextConsecutive(int[] nums, int start, bool[] indexMarkAsDelete){
        int i = 0;
        for(i = start + 1; i < nums.Length; i++){
            if(indexMarkAsDelete[i]) continue;// already taken
            if(nums[i] - nums[start] > 1){ // Not consecutive
                return null;
            }
            if(nums[i] - nums[start] == 1){
                return i;
            }
            else{ // equals
                continue;
            }
        }
        return nums.Length;// out of index
    }
}
//注意：不要限制三连只为三个，假设(1,2,3)，出现4的时候,先找end有没有3，有的话就变成(1,2,3,4)
//而不是先去找(4，5，6),因为如果有4,5,6的话就是(1，2，3，4，5，6)， 如果没有的话（比如只有4,6）
//那你把4放不放到(1,2,3)里面结果都是一样的
//例子 http://www.cnblogs.com/pk28/p/7384602.html [1,2,3,4,5,5,5,6,6,7,7,8,9,10]
//在处理的时候，按照上上面的套路（1,2,3）(4,5,6),(5,6,7),(7,8,9) 剩下 5和10,   5，和10 只能放在 3,6,7,9后面，10可以放在9后面，但是5没有地方放，返回false。
//可是 我们肉眼能找到（1,2,3,4,5）（5,6,7）（5,6,7）（8,9,10）这样合法的分割，应该返回true。
