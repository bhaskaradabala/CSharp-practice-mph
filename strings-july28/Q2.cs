/*
Write a C# Sharp program to separate individual characters from a string.
Test Data :
Input the string : google.com
Expected Output :

The characters of the string are : 
g o o g l e  .  c  o  m
*/

using System;
class HelloWorld {
  static void Main() {
      string str = "hello world";
      
      foreach(char c in str){
          Console.Write(c + " ");
      }
    
  }
}
