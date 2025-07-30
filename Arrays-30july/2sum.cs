/*
https://leetcode.com/problems/two-sum/
*/

//brute-force
//O(n^2)
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int l = nums.Length;
        for(int i=0; i<l;i++){
            for(int j=i+1; j<l-1;j++ ){
                if(nums[i]+nums[j] == target){
                    int[] res = new int[2];
                    res[0] =i;
                    res[1]=j;

                    return res;
                }
            }
        }
         return new int[0];
    }
}

//solution
//using hash-map
//O(n) - time complexity
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>();

        for(int i=0; i<nums.Length; i++){
            int c = target - nums[i];
            if(map.ContainsKey(c)){
                int[] res = new int[2];
                res[0] = map[c];
                res[1] =i;
                return res;
            }
            map[nums[i]]=i;
        }
        return new int[0];
    }
}


