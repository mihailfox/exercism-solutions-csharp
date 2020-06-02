using System;
using System.Text;

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
            var strBld = new StringBuilder();

            var tempString = phrase.Split(new[] { " ", "-", "_", "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in tempString)
            {
                strBld.Append(s.ToUpperInvariant(), 0, 1);
            }
            return strBld.ToString();
        }
    }
}