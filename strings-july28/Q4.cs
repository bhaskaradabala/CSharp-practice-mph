/*
 Write a program in C# Sharp to compare two strings without using a string library functions.
Test Data :
Input the 1st string : This is first string
Input the 2nd string : This is first string
Expected Output :

The length of both strings are equal and 
also, both strings are equal.
*/

using System;
class HelloWorld {
  static void Main() {
      string str1 = "hello world";
      string str2 = "hello world";
      bool flag= true;
      int l1 = str1.Length;
      int l2 = str2.Length;
      if(l1==l2) {
          for(int i=0; i<l1; i++){
              if(str1[i]!=str2[i]){
                  flag = false;
                  break;
              }
          
      }
      }
      else{
          flag = false;
      }
      
      if(l1==l2 && flag){
          Console.WriteLine("Given Strings are same.");
      }
      else{
          Console.WriteLine("Given Strings are not same.");
      }
  }
}
