public class Solution {
    public bool IsSubsequence(string s, string t) {
        int s_pointer=0;
        int t_pointer=0;

        while(s_pointer<s.Length && t_pointer<t.Length){
            if(s[s_pointer]==t[t_pointer])
                s_pointer+=1;
            t_pointer++;
        }
        if(s_pointer==s.Length)
            return true;
        return false;
    }
}