// Sliding window
public class Solution {
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || s.Length < p.Length) return result;
        // Make dictionary for p
        Dictionary<char, int> dictP = DictP(p);
        HashSet<char> setP = SetP(p);
        var P = dictP.ToDictionary(kv => kv.Key, kv => kv.Value); // hard copy
        int left = 0, right = 0;
        //move right
        while (right < s.Length)
        {
            // Not even a char in p -> reset dictionary. Move left pointer to next position.
            if (!setP.Contains(s[right]))
            {
                P = dictP.ToDictionary(kv => kv.Key, kv => kv.Value); // hard copy
                right++;
                left = right;
                continue;
            }
            // Always record the number which right points to.
            Decrease(P, s[right]);
            // When sliding window reaches the length of p. Make a check of the dict.
            if (right - left + 1 == p.Length)
            {
                if (P.Count == 0)
                {
                    //Find a resut
                    result.Add(left);
                }
                // Move Left pointer forward. Before making the move, add the number back to the dict. 
                Increase(P, s[left]);
                left++;
            }
            right++;
        }
        return result;
    }

    /*
      We are maintaining a dictionary to match the dictionary of string p.
      When this dictionary has 0 element, we regard it as a match with the dict of P.
      Therefore, we don't allow value of 0, i.e. [key, 0]
      When the value comes to 0, we remove the key.
    */
    // The value is possible to be < 0
    private void Increase(Dictionary<char, int> d, char c){
        if(!d.ContainsKey(c)){
            d[c] = 1;
        }
        else{
            d[c]++;
            if(d[c] == 0) {
                d.Remove(c);
            }
        }
    }

    private void Decrease(Dictionary<char, int> d, char c){
        if(!d.ContainsKey(c)){
            d[c] = -1;
        }
        else{
            d[c]--;
            if(d[c] == 0) {
                d.Remove(c);
            }
        }
    }
    private Dictionary<char, int> DictP(string p){
        var dictP = new Dictionary<char, int>();
        for(int i = 0; i < p.Length; i++){
            if(!dictP.ContainsKey(p[i])){
                dictP[p[i]] = 1;
            }
            else{
                dictP[p[i]]++;
            }
        }
        return dictP;
    }
    private HashSet<char> SetP(string p){
        var setP = new HashSet<char>();
        for(int i = 0; i < p.Length; i++){
            setP.Add(p[i]);
        }
        return setP;
    }
}
// TLE solution
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || s.Length < p.Length) return result;
        for(int i = 0; i + p.Length <= s.Length; i++){
            if(IsAnagram(s.Substring(i, p.Length), p)){
                result.Add(i);
            }
        }
        return result;
    }

    private bool IsAnagram(string a, string b){
        if(string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b)) return true;
        if(string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;
        if(a.Length != b.Length) return false;
        Dictionary<char, int> dictA = new Dictionary<char, int>();
        Dictionary<char, int> dictB = new Dictionary<char, int>();
        for(int i = 0; i < a.Length; i++){
            if(!dictA.ContainsKey(a[i])){
                dictA[a[i]] = 1;
            }
            else{
                dictA[a[i]]++;
            }
        }
        for(int i = 0; i < b.Length; i++){
            if(!dictB.ContainsKey(b[i])){
                dictB[b[i]] = 1;
            }
            else{
                dictB[b[i]]++;
            }
        }
        foreach(var kv in dictA){
            if(!dictB.ContainsKey(kv.Key) || dictB[kv.Key] != kv.Value) return false;
        }
        return true;
    }
}
