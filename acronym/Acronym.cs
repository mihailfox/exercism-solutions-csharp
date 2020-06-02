using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if (string.IsNullOrWhiteSpace(phrase))
        {
            return null;
        }
        else
        {
            string result = "";

            var tempString = phrase.Split(new string[] { " ", "-", "_", "," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in tempString)
            {
                result += s.ToUpperInvariant().Substring(0, 1);
            }
            return result;
        }
    }
}