
/* 
https://leetcode.com/problems/rotate-array/description/?envType=study-plan-v2&envId=top-interview-150
*/

public class Solution {
    public void Rotate(int[] nums, int k) {
        
        int n = nums.Length;
        k = k%n;

        reverse(nums, 0, n-1);
        reverse(nums, 0, k-1);
        reverse(nums, k, n-1);
    }
    
    public void reverse(int[] nums, int start, int end){
        while(start < end){
            int temp = nums[end];
            nums[end]= nums[start];
            nums[start]= temp;
            start++;
            end--;
        }
    }
        
    
}
