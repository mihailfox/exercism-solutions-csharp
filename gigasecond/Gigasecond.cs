using System;

public static class Gigasecond
{
    private const int _gigasecond = 1_000_000_000;

    public static DateTime Add(DateTime moment) => moment.AddSeconds(_gigasecond);
}