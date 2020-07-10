using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var output = new StringBuilder();
        foreach (var inputChar in text)
        {
            output.Append(Transform(inputChar, shiftKey));
        }
        return output.ToString();
    }

    private static char Transform(char inputChar, int shiftKey)
    {
        if (!char.IsLetter(inputChar))
        {
            return inputChar;
        }

        bool isUpper = char.IsUpper(inputChar);
        int firstLetterCode = isUpper ? 'A' : 'a';
        int lastLetterCode = isUpper ? 'Z' : 'z';

        int outputCharCode = inputChar + shiftKey;

        var output = (char)(outputCharCode <= lastLetterCode
                    ? outputCharCode
                    : Mod(outputCharCode, lastLetterCode) + firstLetterCode - 1);

        return output;
    }

    // this method exists for the cases when dividend % divisor returns negative number
    private static int Mod(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            return dividend;
        }

        int remainder = dividend % divisor;
        return remainder < 0
            ? remainder + divisor
            : remainder;
    }
}