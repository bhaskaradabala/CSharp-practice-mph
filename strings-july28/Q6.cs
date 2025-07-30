/*
Write a program in C# Sharp to copy one string to another string.
Test Data :
Input the string : This is a string to be copied.
Expected Output :

The First string is : This is a string to be copied. 

The Second string is : This is a string to be copied. 

Number of characters copied : 31
*/

using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter Input String");
      string str = Console.ReadLine();
      
      int l = str.Length;
      int count =0;
      char[] copy = new char[l];
      for(int i=0; i<l;i++){
          copy[i] = str[i];
          count++;
      }
      string strcopy = new string(copy);
      
      Console.WriteLine("First  string: " + str);
      Console.WriteLine("Copied string: " + strcopy);
      Console.WriteLine("Number of character copied: " + l);
  }
}
