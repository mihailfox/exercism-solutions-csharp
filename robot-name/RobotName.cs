using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    // maximum number of robot names for exercise format LLDDD = 26 * 26 * 10 * 10 * 10
    private const int maxRobots = 676_000;

    private const string numberFormat = "{0:000}";
    private static readonly List<string> usedNames = new List<string>();
    private static readonly Random random = new Random();

    public string Name { get; private set; }

    public Robot() => Name = GenerateName();

    public void Reset() => Name = GenerateName();

    private static string GenerateName()
    {
        if (usedNames.Count == maxRobots)
        {
            throw new MaximumNumberOfRobotsException("You have generated the maximum number of robot names",
                usedNames[^1]);
        }

        var randomName = new StringBuilder();

        var output = string.Empty;
        do
        {
            randomName
                .Append(RandomString())
                .AppendFormat(numberFormat, RandomNumber());

            output = randomName.ToString();
        } while (usedNames.Contains(output));

        usedNames.Add(output);
        return output;
    }

    private static string RandomString(int length = 2)
    {
        var randomString = new StringBuilder();
        for (var i = 0; i < length; i++)
        {
            randomString.Append(RandomLetter());
        }

        return randomString.ToString();
    }

    private static char RandomLetter(bool lowerCase = false)
    {
        var randomLetter = lowerCase ? Convert.ToChar(random.Next('a', 'z')) : Convert.ToChar(random.Next('A', 'Z'));

        return randomLetter;
    }

    private static int RandomNumber(int start = 0, int end = 999)
    {
        var randomNumber = random.Next(start, end);

        return randomNumber;
    }
}