public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        var sub =  ((s + s).Substring(1, (s.Length * 2) - 2));
        return sub.Contains(s) ? true : false;
    }
}
