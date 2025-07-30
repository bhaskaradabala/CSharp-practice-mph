/*
1.Write a C# Sharp program to find the length of a string without using a library function.
Test Data :
Input the string : google.com
Expected Output :

Length of the string is : 15 
*/

using System;
class Program {
  static void Main() {
      string str = "hello world";
      int length = 0;
      foreach(char c in str){
          length++;
      }
    Console.WriteLine(length);
  }
}
