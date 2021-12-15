using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var chars = new char[text.Length];
        
        for (var i = 0; i < text.Length; i++)
            chars[i] = GetRotatedChar(text[i], shiftKey);

        return new string(chars);
    }

    private static char GetRotatedChar(char c, int charShift)
    {
        if (!TryGetFirstLetterCharNum(c, out var firstCharNum))
            return c;

        int adjustedCharShift = charShift;

        var currentCharNum = (int) c;
        var relativeCharPosition = (int) (currentCharNum - firstCharNum);
        var relativeCharShift = relativeCharPosition + charShift;

        var charsInRotation = 26;

        if (relativeCharShift >= charsInRotation)
        {
            var numberOfRotations = (relativeCharShift / charsInRotation);
            adjustedCharShift = charShift - numberOfRotations * charsInRotation;
        }

        return (char) (c + adjustedCharShift);
    }

    private static bool TryGetFirstLetterCharNum(char c, out int firstCharNum)
    {
        switch (c)
        {
            case >= 'a' and <= 'z':
                firstCharNum = 'a';
                return true;
            case >= 'A' and <= 'Z':
                firstCharNum = 'A';
                return true;
            default:
                firstCharNum = default;
                return false;
        }
    }
}