public class Solution {
    public int Calculate(string s) {
        if(string.IsNullOrEmpty(s)){
          return 0;
        }
        // Trim all whitespaces
        s = s.Trim();
        Queue<int> operandsQueue = new Queue<int>();
        Queue<char> operatorQueue = new Queue<char>();
        int adder = 0;
        bool isAdd = true;
        int multiplier = 1;
        bool isMul = true;
        string number = string.Empty;
        for(int i = 0; i < s.Length; i++){
          /*
            If * or /
            continue load number into queue
          */
          if(s[i] == '*' || s[i] == '/'){
            operandsQueue.Enqueue(Int32.Parse(number));
            operatorQueue.Enqueue(s[i]);
            number = string.Empty;
          }
          /*
            If + or -
            continue load number into queue
          */
          else if(s[i] == '+' || s[i] == '-'){
            operandsQueue.Enqueue(Int32.Parse(number));
            multiplier = flushQueue(operandsQueue, operatorQueue);
            operandsQueue.Clear();
            operatorQueue.Clear();
            adder = isAdd ? adder + multiplier : adder - multiplier;
            isAdd = s[i] == '+';
            number = string.Empty;
          }
          /*
            If arithmetic number,
            continue appending to format a number
          */
          else{
            number += s[i];
          }
        }
        //Ending
        operandsQueue.Enqueue(Int32.Parse(number));
        multiplier = flushQueue(operandsQueue, operatorQueue);
        operandsQueue.Clear();
        operatorQueue.Clear();
        adder = isAdd ? adder + multiplier : adder - multiplier;
        return adder;
    }
    private int flushQueue(Queue<int> operandsQueue, Queue<char> operatorQueue){
      int result = 1;
      bool isMul = true;
      int number;
      while(operatorQueue.Count > 0) {
        number = operandsQueue.Dequeue();
        result = isMul ? result * number : result / number;
        isMul = operatorQueue.Dequeue() == '*';
      }
      number = operandsQueue.Dequeue();
      result = isMul ? result * number : result / number;
      return result;
    }

}
