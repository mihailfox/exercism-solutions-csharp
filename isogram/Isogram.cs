using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return true;
        }
        else
        {
            return word
                .Where(char.IsLetter)
                .GroupBy(char.ToLower)
                .All(g => g.Count() == 1);
        }
    }
}