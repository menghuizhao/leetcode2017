public class Solution {
    public string GetHint(string secret, string guess) {
        if(string.IsNullOrEmpty(secret) || string.IsNullOrEmpty(secret) || secret.Length != guess.Length){
            return "0A0B";
        }
        int bullCount = 0;
        int cowCount = 0;
        var secretDict = new Dictionary<char, int>();
        var guessDict = new Dictionary<char, int>();
        for(int i = 0; i < secret.Length; i++){
            //exactly equal
            if(secret[i] == guess[i]){
                bullCount++;
            }
            else{
                if(!secretDict.ContainsKey(secret[i])){
                    secretDict[secret[i]] = 1;
                }
                else{
                    secretDict[secret[i]] += 1;
                }
                if(!guessDict.ContainsKey(guess[i])){
                    guessDict[guess[i]] = 1;
                }
                else{
                    guessDict[guess[i]] += 1;
                }
            }
        }
        foreach(char c in secretDict.Keys){
            int timeInSecret = secretDict[c];
            if(guessDict.ContainsKey(c)){
                int timeInGuess = guessDict[c];
                cowCount += Math.Min(timeInSecret, timeInGuess);
            }
        }
        return bullCount + "A" + cowCount + "B";
    }
}
