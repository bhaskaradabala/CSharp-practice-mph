using System;

class Program
{
    static string SwapCase(string input)
    {
        char[] arr = input.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            char c = arr[i];
            if (char.IsUpper(c))
                arr[i] = char.ToLower(c);
            else if (char.IsLower(c))
                arr[i] = char.ToUpper(c);
        }
        return new string(arr);
    }

    static void Main()
    {
        Console.Write("Input the string : ");
        string src = Console.ReadLine();
        string result = SwapCase(src);
        Console.WriteLine("the string after convertion : " + result);
    }
}
