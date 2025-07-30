/*
Write a C# Sharp program to sort a string array in descending order.
Test Data :
Input the string : this is a string

*/

using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter Input String");
      string str = Console.ReadLine();
      
      string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
      
      Array.Sort(words, (x,y) => y.CompareTo(x));
      
      foreach(string word in words){
          Console.Write(word + " ");
      }
      
      
  }
}

/*Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
Test Data :
Input number of strings :3
Input 3 strings below :
abcd
zxcv
mnop
Expected Output :

After sorting the array appears like : 
abcd 
mnop 
zxcv
*/

// BUBBLE SORT

using System;
class HelloWorld {
  static void Main() {
      Console.Write("Enter number of strings: ");
      int n = Convert.ToInt32(Console.ReadLine());
      
      string[] words = new string[n];
      
      for(int k=0; k<n; k++){
          words[k] = Console.ReadLine();
      }
      
      for(int i=0; i<n-1;i++){
          for(int j=0; j<n-i-1;j++ ){
              if(words[j].CompareTo(words[j+1])>0){
                  string temp = words[j];
                  words[j]=words[j+1];
                  words[j+1]=temp;
              }
          }
      }
      
      Console.WriteLine("new order after bubble sort: ");
      foreach(string word in words){
          Console.WriteLine(word);
      }
      
      
  }
}
