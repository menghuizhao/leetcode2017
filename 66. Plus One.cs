//Even Int64 will overflow, use BigInteger
public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> num = digits.ToList();
        StringBuilder sb = new StringBuilder();
        foreach(int digit in num){
            sb.Append(digit.ToString());
        }
        var newNum =  System.Numerics.BigInteger.Parse(sb.ToString()) + 1;
        string newStr = newNum.ToString();
        List<int> newDigits = new List<int>();
        for(int i = 0; i < newStr.Length; i++){
            char c = newStr[i];
            int digit = (int)(c - '0');
            newDigits.Add(digit);
        }
        return newDigits.ToArray();
    }
}
