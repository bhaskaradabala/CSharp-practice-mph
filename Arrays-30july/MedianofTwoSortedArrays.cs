
//https://leetcode.com/problems/median-of-two-sorted-arrays/description/
//didnt follow time complexity O(log(m+n))
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int a = nums1.Length;
        int b = nums2.Length;
        int n=a+b;
        int[] arr= new int[n];
        for(int i=0; i<a; i++){
            arr[i]=nums1[i];
        }
        for(int j=0; j<b;j++){
            arr[a+j]=nums2[j];
        }
        Array.Sort(arr);
        if(n%2 !=0){
            return arr[n/2];
        }
        else{
            int k= n/2;
            return (arr[k]+arr[k-1])/2.0;
             
        }
    }
}
