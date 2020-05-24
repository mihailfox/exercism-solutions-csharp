using System;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if (string.IsNullOrEmpty(phrase) | string.IsNullOrWhiteSpace(phrase))
        {
            return null;
        }
        else
        {
            string result = "";

            string[] tempString = phrase.Split(new string[] { " ", "-", "_", "," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in tempString)
            {
                result += s.ToUpper().Substring(0, 1);
            }
            return result;
        }

    }
}