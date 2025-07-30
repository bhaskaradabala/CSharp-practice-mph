//https://leetcode.com/problems/valid-palindrome/description/?envType=study-plan-v2&envId=top-interview-150


public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder res = new StringBuilder(s.Length);

        foreach (char c in s){
            if (char.IsLetterOrDigit(c)){
                res.Append(char.ToLower(c));
            }
        }

        string result = res.ToString();
        int left = 0;
        int right = res.Length - 1;
        while(left < right){
            if(result[left] != result[right]){
                return false;
                left++;
                right--;
            }
        }

        return true;



        
    }
}
