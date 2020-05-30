using System;
using System.Linq;

public class SimpleCipher
{
    private const string _alphabet = "abcdefghijklmnopqrstuvwxyz";

    public SimpleCipher()
    {
        Key = _alphabet;
    }

    public SimpleCipher(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public string Decode(string ciphertext)
    {
        return new string(ciphertext.Select(Decode).ToArray());
    }

    public string Encode(string plaintext)
    {
        return new string(plaintext.Select(Encode).ToArray());
    }

    private char Decode(char character, int index)
    {
        return ToChar((ToInteger(character) - KeyValue(index) + _alphabet.Length) % _alphabet.Length);
    }

    private char Encode(char character, int index)
    {
        return ToChar((ToInteger(character) + KeyValue(index)) % _alphabet.Length);
    }

    private int ToInteger(char character)
    {
        return character - _alphabet[0];
    }

    private char ToChar(int number)
    {
        return Convert.ToChar(number + _alphabet[0]);
    }

    private int KeyValue(int index)
    {
        return ToInteger(Key[index % Key.Length]);
    }
}