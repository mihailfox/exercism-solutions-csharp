using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }
        else
        {
            int charsFound = 0;

            foreach (char s in alphabet)
            {
                if (input.ToLower().Contains(s))
                {
                    charsFound++;
                }
            }
            if (charsFound >= alphabet.Length)
            {
                return true;
            }
        }
        return false;
    }
}