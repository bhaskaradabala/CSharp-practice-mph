/*
Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
Test Data :
Input a character: Z

Expected Output :

The character is uppercase.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (char.IsLetter(ch))
        {
            if (char.IsUpper(ch))
                Console.WriteLine("The character is uppercase.");
            else
                Console.WriteLine("The character is lowercase.");
        }
        else
        {
            Console.WriteLine("The entered character is not an alphabetic character.");
        }
    }
}
