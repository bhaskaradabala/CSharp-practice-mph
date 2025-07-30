/*
 Write a program in C# Sharp to print individual characters of the string in reverse order.
Test Data :
Input the string : google.com
Expected Output :

The characters of the string in reverse are : 

m  o  c  .  e l g o o g
*/

using System;
class HelloWorld {
  static void Main() {
      string str = "hello world";
      int l = str.Length -1;
      while(l>=0){
          Console.Write(str[l] +" ");
          l--;
      }
      Console.WriteLine();
    
  }
}
