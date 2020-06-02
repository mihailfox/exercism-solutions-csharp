using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "not a natural number");
        }

        var divisorSum = AddDivisors(number);

        var classification = GetClassification(number, divisorSum);
        return classification;
    }

    private static Classification GetClassification(int number, int divisorSum)
    {
        if (divisorSum == number)
        {
            return Classification.Perfect;
        }
        else if (divisorSum > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Deficient;
        }
    }

    private static int AddDivisors(int number)
    {
        var divisorSum = 0;
        for (var i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                divisorSum += i;
            }
        }

        return divisorSum;
    }
}