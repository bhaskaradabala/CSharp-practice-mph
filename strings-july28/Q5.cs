/*
Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
Test Data :
Input the string : Welcome to google.com
Expected Output :

Number of Alphabets in the string is : 21 
Number of Digits in the string is : 1 
Number of Special characters in the string is : 4 

*/

using System;
class HelloWorld {
  static void Main() {
      string str = "www.google1.com";
      int dcount=0;
      int acount=0;
      int scount=0;
      for(int i=0; i<str.Length; i++){
          if((str[i]>='a'&&str[i]<='z')||(str[i]>='A'&&str[i]<='Z')){
              acount++;
          }
          else if(str[i]>='0'&&str[i]<='9'){
              dcount++;
          }
          else{
              scount++;
          }
      }
      Console.WriteLine("digits count: " + dcount);
      Console.WriteLine("alphabet count: " + acount);
      Console.WriteLine("special character count: " + scount);
  }
}
