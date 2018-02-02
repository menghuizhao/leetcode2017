public class Solution {
    public int MaxArea(int[] height) {
        if(height == null || height.Length == 0) return 0;
        int max = 0;
        int left = 0;
        int right = height.Length - 1;
        do {
            int contain = Math.Min(height[left], height[right]) * (right - left);
            if(contain > max){
                max = contain;
            }

            if(height[left] <= height[right]){
                left++;
            }
            else{
                right--;
            }
        } while(left < right);
        return max;
    }
}
// https://segmentfault.com/a/1190000008824222
// 减少循环的核心思路是省去没有必要的遍历，并且确保所需的答案一定能被遍历到
// 假设现在有一个容器，则容器的盛水量取决于容器的底和容器较短的那条高
// 则我们可以从最大的底长入手，即当容器的底等于数组的长度时，则容器的盛水量为较短边的长乘底
// 可见 只有较短边会对盛水量造成影响，因此移动较短边的指针，并比较当前盛水量和当前最大盛水量。直至左右指针相遇。
//
// 主要的困惑在于如何移动双指针才能保证最大的盛水量被遍历到
// 假设有左指针left和右指针right，且left指向的值小于right的值，假如我们将右指针左移，则右指针左移后的值和左指针指向的值相比有三种情况
//
// 右指针指向的值大于左指针
// 这种情况下，容器的高取决于左指针，但是底变短了，所以容器盛水量一定变小
//
// 右指针指向的值等于左指针
// 这种情况下，容器的高取决于左指针，但是底变短了，所以容器盛水量一定变小
//
// 右指针指向的值小于左指针
// 这种情况下，容器的高取决于右指针，但是右指针小于左指针，且底也变短了，所以容量盛水量一定变小了
//
// 综上所述，容器高度较大的一侧的移动只会造成容器盛水量减小
