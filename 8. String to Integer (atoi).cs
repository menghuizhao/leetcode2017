public class Solution {
    public int MyAtoi(string str) {
        if(string.IsNullOrEmpty(str)) return 0;
        int sign = 1;
        int num = 0;
        int i = 0;
        while (str[i] == ' ') { i++; }
        if (str[i] == '-'){
            sign = -1;
            i++;
        }
        else if(str[i] == '+') {
            sign = 1;
            i++;
        }
        while (i < str.Length && str[i] >= '0' && str[i] <= '9') {
            if (num > Int32.MaxValue / 10 || (num == Int32.MaxValue / 10 && str[i] - '0' > 7)) {
                if (sign == 1) return Int32.MaxValue;
                else return Int32.MinValue;
            }
            num  = 10 * num + (int)(str[i++] - '0');
        }
        return num * sign;
    }
}
