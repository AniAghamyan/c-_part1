using System;

class Program
{
    static bool IsPalindrome(string input)
    {        
        string processedString = new string(input.ToLower().ToCharArray());
        int start = 0;
        int end = processedString.Length - 1;
        while (start < end)
        {
            if (processedString[start] != processedString[end])
            {
                return false; 
            }
            start++;
            end--;
        }

        return true; 
    }

    static void Main()
    {
        string input = "racecar";  
        Console.WriteLine($"Input: {input}");

        if (IsPalindrome(input))
        {
            Console.WriteLine("Output: True.");
        }
        else
        {
            Console.WriteLine("Output: False.");
        }
    }
}
