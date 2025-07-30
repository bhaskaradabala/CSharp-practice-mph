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
      string str = "hello world";
      
      int l = str.Length;
      for(int i=l-1;i>=0;i--){
          Console.Write(str[i] + " ");
      } 
    
  }
}
