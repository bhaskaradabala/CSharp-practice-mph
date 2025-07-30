/*
 Write a C# Sharp program to check whether a given substring is present in the given string.
Test Data :
Input the string : This is a Test String
Input the substring to search : Test
Expected Output :

The substring exists in the string
*/

using System;
class Program{
static void Main()
    {
        Console.Write("Input the string: ");
        string source = Console.ReadLine();
        Console.Write("Input the substring to search: ");
        string pattern = Console.ReadLine();

        bool found = ContainsSubstring(source, pattern);

        Console.WriteLine(found ? "\nsubstring exists" : "\nsubstring doesn't exist");
    }

    static bool ContainsSubstring(string s, string pat)
    {
        int n = s.Length, m = pat.Length;
        if (m == 0 || m > n) return false;

        for (int i = 0; i <= n - m; i++)
        {
            bool match = true;
            for (int j = 0; j < m; j++)
            {
                if (s[i + j] != pat[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
                return true;
        }

        return false;
    }
    
}
