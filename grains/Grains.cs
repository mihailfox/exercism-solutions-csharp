using System;

public static class Grains
{
    public static int ChessBoardSize { get; set; } = 64;

    public static ulong Square(int n)
    {
        ulong result;
        if (n <= 0 | n > ChessBoardSize)
        {
            throw new ArgumentOutOfRangeException("n", $"board size must be between 1-{ChessBoardSize}");
        }
        result = (ulong)Math.Pow(2, n - 1);

        return result;

    }

    public static ulong Total()
    {
        ulong result = 0;

        for (int i = 0; i < ChessBoardSize; i++)
        {

            result += (ulong)Math.Pow(2, i);

        }

        return result;
    }
}