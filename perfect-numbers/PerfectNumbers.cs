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
            throw new ArgumentOutOfRangeException("number", "not a natural number");
        }
        number = Convert.ToInt32(number);
        int divisorSum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                divisorSum += i;
            }
        }

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
}