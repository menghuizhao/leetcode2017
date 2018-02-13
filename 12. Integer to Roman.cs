public class Solution {
    public string IntToRoman(int num) {
        string[] symbol = new string[]{"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
        int[] value = new int[]{1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        StringBuilder sb = new StringBuilder();
        int i = 0;
        while(num > 0)
        {
            while(num >= value[i])
            {
                num -= value[i];
                sb.Append(symbol[i]);
            }
            i++;
        }
        return sb.ToString();
    }
}
//http://blog.csdn.net/havenoidea/article/details/11848921
//greedy
