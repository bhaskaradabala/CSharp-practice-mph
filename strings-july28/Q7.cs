/*
Write a C# Sharp program to count the number of vowels or consonants in a string.
Test Data :
Input the string : Welcome to google.com
Expected Output :

The total number of vowel in the string is : 9 
The total number of consonant in the string is : 12
*/
using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter Input String");
      string str = Console.ReadLine();
      
      int vowcount = 0;
      int concount =0;
      
      for(int i=0; i<str.Length; i++){
          char c = char.ToLower(str[i]);
          if(c>='a' && c<='z'){
              if(c=='a' || c=='e' || c=='i' || c=='o' || c=='u'){
              vowcount++;
                  
              }
              else{
                  concount++;
                  
              }
          }
      }
      Console.WriteLine("Vowels count: "+ vowcount);
      Console.WriteLine("Consonants count: "+ concount);   
  }
}
