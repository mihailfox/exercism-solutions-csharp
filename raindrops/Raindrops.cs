using System.Collections.Generic;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var raindrops = new Dictionary<int, string>
        {
            { 3, "Pling" },
            { 5, "Plang" },
            { 7, "Plong" }
        };

        var factors = GetFactors(number);
        var output = string.Empty;

        foreach (var factor in factors)
        {
            if (raindrops.ContainsKey(factor))
            {
                output += raindrops[factor];
            }
        }

        return string.IsNullOrEmpty(output) ? number.ToString() : output;
    }

    private static List<int> GetFactors(int number)
    {
        var factors = new List<int>();

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors.Add(i);
            }
        }

        return factors;
    }
}