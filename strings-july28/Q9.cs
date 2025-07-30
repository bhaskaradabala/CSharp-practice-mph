/*
Write a program in C# Sharp to extract a substring from a given string without using the library function.
Test Data :
Input the string : This is a test string
Input the position to start extraction :5
Input the length of substring :5
Expected Output :

The substring retrieve from the string is :  is a
*/

using System;

class Program {
  static void Main() {
    Console.Write("Input string : ");
    string str = Console.ReadLine();
    Console.Write("position to start extraction : ");
    int p = Convert.ToInt32(Console.ReadLine());
    Console.Write("length of substring : ");
    int l = Convert.ToInt32(Console.ReadLine());

    char[] substr = new char[l];
    int count = 0;
    for (int i = 0; i < l && p + i < str.Length; i++) {
      substr[i] = str[p + i];
      count++;
    }
    string result = new string(substr);
    Console.WriteLine("substring: " + result);
  }
}
