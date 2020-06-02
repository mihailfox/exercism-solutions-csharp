using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private readonly string BaseWord;

    public Anagram(string baseWord)
    {
        BaseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        var anagrams = new List<string>();

        foreach (var word in potentialMatches)
        {
            if (IsAnagram(word, BaseWord))
            {
                anagrams.Add(word);
            }
        }

        return anagrams.ToArray();
    }

    private bool IsAnagram(string inputOne, string inputTwo)
    {
        if (string.Equals(inputOne, inputTwo, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var sortedOne = string.Concat(inputOne.ToLower().OrderBy(c => c));
        var sortedTwo = string.Concat(inputTwo.ToLower().OrderBy(c => c));

        return sortedOne == sortedTwo;
    }
}