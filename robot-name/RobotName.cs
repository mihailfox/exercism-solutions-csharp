using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Robot
{
    // maximum number of robot names for exercise format LLDDD = 26 * 26 * 10 * 10 * 10
    private const int MaxRobots = 676_000;

    private const string NumberFormat = "000";
    private static readonly List<string> usedNames = new List<string>();
    private static readonly Random random = new Random();

    public string Name { get; private set; }

    public Robot() => Name = GenerateName();

    public void Reset() => Name = GenerateName();

    private static string GenerateName()
    {
        if (usedNames.Count == MaxRobots)
        {
            throw new MaximumNumberOfRobotsReachedException("You have generated the maximum number of robot names",
                usedNames[^1]);
        }

        var randomName = string.Empty;
        do
        {
            randomName = $"{RandomString()}{RandomNumber().ToString(NumberFormat)}";
        } while (usedNames.Contains(randomName));

        usedNames.Add(randomName);
        return randomName;
    }

    private static string RandomString(int length = 2)
    {
        var randomString = string.Empty;
        for (var i = 0; i < length; i++)
        {
            randomString += RandomLetter();
        }

        return randomString;
    }

    private static char RandomLetter(bool lowerCase = false)
    {
        var randomLetter = lowerCase ? Convert.ToChar(random.Next('a', 'z')) : Convert.ToChar(random.Next('A', 'Z'));

        return randomLetter;
    }

    private static int RandomNumber(int start = 0, int end = 1000)
    {
        var randomNumber = random.Next(start, end);

        return randomNumber;
    }
}