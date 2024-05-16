using System;
using System.Text.RegularExpressions;

public static class UkrainianStringUtils
{
    public static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "аеєиіїоуюя";
        foreach (char ch in input.ToLower())
        {
            if (vowels.Contains(ch))
            {
                count++;
            }
        }
        return count;
    }

    public static int CountConsonants(string input)
    {
        int count = 0;
        string consonants = "бвгґджзйклмнпрстфхцчшщ";
        foreach (char ch in input.ToLower())
        {
            if (consonants.Contains(ch))
            {
                count++;
            }
        }
        return count;
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string RemoveDuplicates(string input)
    {
        string result = "";
        foreach (char ch in input)
        {
            if (result.IndexOf(ch) == -1)
            {
                result += ch;
            }
        }
        return result;
    }

    public static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, @"[\p{P}\p{S}]", "");
    }

}