using System;
using System.Text;

public class SimpleCipher
{
    private static int BaseCharacter { get; } = 32;
    private static int TopCharacter { get; } = 255;
    private const int CharShift = 3;

    public SimpleCipher()
    {
    }

    public SimpleCipher(string key) => Key = key;

    public string Key { get; set; } = "";

    public string Encode(string plaintext)
    {
        if (string.IsNullOrWhiteSpace(plaintext))
        {
            Console.WriteLine("Input string is not valid!");
            throw new ArgumentException();
        }

        var output = new StringBuilder();
        foreach (var inputChar in plaintext)
        {
            output.Append(EncodeCharacter(inputChar, CharShift));
        }
        return output.ToString();
    }

    public string Decode(string ciphertext)
    {
        if (string.IsNullOrWhiteSpace(ciphertext))
        {
            throw new ArgumentException("Input string is not valid!");
        }

        var output = new StringBuilder();
        foreach (var inputChar in ciphertext)
        {
            output.Append(EncodeCharacter(inputChar, -CharShift));
        }
        return output.ToString();
    }

    private static char EncodeCharacter(char input, int shift)
    {
        if (!IsPrintableChar(input))
        {
            return input;
        }

        var output = (char)(Mod(input + shift - BaseCharacter, TopCharacter - BaseCharacter + 1) + BaseCharacter);
        return output;
    }

    private static bool IsPrintableChar(char input)
    {
        return input >= BaseCharacter || input < TopCharacter;
    }

    private static int Mod(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            return divisor;
        }

        var remainder = dividend % divisor;

        return remainder < 0 ? remainder + divisor : remainder;
    }
}