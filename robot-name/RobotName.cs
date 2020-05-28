using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    private static readonly Random random = new Random();
    private static readonly List<string> _previousNames = new List<string>();

    public Robot() => Name = GenerateName();

    public string Name { get; private set; }

    public void Reset() => Name = GenerateName();

    private static string GenerateName()
    {
        var randomCode = new StringBuilder();
        var output = "";
        do
        {
            randomCode
                .Append(RandomString())
                .Append(RandomNumber());

            output = randomCode.ToString();
        } while (_previousNames.Contains(output));

        _previousNames.Add(output);
        return output;
    }

    private static string RandomString(int length = 2)
    {
        var randomString = new StringBuilder();
        for (int i = 0; i < length; i++)
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

    private static string RandomNumber(int start = 100, int end = 1000)
    {
        var randomNumber = random.Next(start, end);

        return randomNumber.ToString();
    }
}