public class Solution {
    public bool IsValid(string s) {
        if(string.IsNullOrEmpty(s)) return true;
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '(' || s[i] == '[' || s[i] == '{'){
                stack.Push(s[i]);
            }
            else{
                if(stack.Count == 0){
                    return false;
                }
                char outChar = stack.Pop();
                if(
                    (
                        s[i] == ')' && outChar == '('
                    )
                    ||
                    (
                        s[i] == ']' && outChar == '['

                    )
                    ||
                    (
                        s[i] == '}' && outChar == '{'
                    )
                ){
                    continue;
                }
                else{
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
