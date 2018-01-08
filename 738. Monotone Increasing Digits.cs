public class Solution {
    public int MonotoneIncreasingDigits(int N)
    {
        if (N < 10) return 0;
        int length = N.ToString().Length;
        int k = 1;
        bool nochange = false;
        //从左到右扫，找到第一个左边一位小于右边一位的数，宣告停止。然后前面一位退位后面都填999
        //e.g. 12333454 找到5，则5退位变成4， 后面都填9
        //需要注意相等，例如 12555554 则最左边的5退位，后面填9，12499999，维护一个k值，只有当右边大于左边一位才前进，所以这个k停留在最左边的5上
        for (int i = 1; i + 1 <= length; i++)
        {
            int a = NthFromLeft(i, N);
            int b = NthFromLeft(i + 1, N);
            if (a < b)
            {
                k = i + 1;
                if (i + 1 == length)
                {
                    nochange = true; // no need to change
                }
            }
            else if (a == b) {
            }
            else if (a > b)
            {
                break;
            }
        }
        //扫描一遍，无需改动
        if (nochange) return N;
        //将 k 指向的数字退位，后面填9
        string strN = N.ToString();
        char[] arr = strN.ToCharArray();
        int kDigit = arr[k - 1] - '0';
        arr[k - 1] = (char)('0' + kDigit - 1);
        for (int i = k; i < arr.Length; i++)
        {
            arr[i] = '9';
        }
        string newInt = new string(arr);
        return Int32.Parse(newInt);
    }

    //nth digit from left
    public int NthFromLeft(int n, int num){
        string s = num.ToString();
        return (int)(s[n - 1] - '0');
    }
}
