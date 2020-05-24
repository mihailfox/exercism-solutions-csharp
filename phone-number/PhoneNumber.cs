using System;
using System.Text.RegularExpressions;

public static class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var cleanedPhoneNumber = Regex.Replace(phoneNumber, @"[\D]", string.Empty);
        if (cleanedPhoneNumber.Length == 11 && cleanedPhoneNumber.StartsWith("1"))
        {
            cleanedPhoneNumber = cleanedPhoneNumber.Substring(1);
        }

        if (!IsValidAreeaCode(cleanedPhoneNumber) || !IsValidExchangeCode(cleanedPhoneNumber))
        {
            throw new ArgumentException();
        }

        return cleanedPhoneNumber;
    }

    private static bool IsValidAreeaCode(string cleanedPhoneNumber)
    {
        return cleanedPhoneNumber.Length == 10
            && cleanedPhoneNumber[0] != '0'
            && cleanedPhoneNumber[0] != '1';
    }

    private static bool IsValidExchangeCode(string cleanedPhoneNumber)
    {
        return cleanedPhoneNumber.Length == 10
            && cleanedPhoneNumber[3] != '0'
            && cleanedPhoneNumber[3] != '1';
    }
}