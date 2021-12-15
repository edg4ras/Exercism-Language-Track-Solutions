using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        return new string(text.Select(x => GetRotatedLetter(x, shiftKey)).ToArray());
    }

    private static char GetRotatedLetter(char c, int charShift)
    {
        if (!char.IsLetter(c))
            return c;

        var firstCharNum = char.IsLower(c) ? 'a' : 'A';
        var currentCharNum = (int) c;
        var relativeCharPosition = (int) (currentCharNum - firstCharNum);
        var relativeCharShift = relativeCharPosition + charShift;
        var charsInRotation = 26;

        if (relativeCharShift >= charsInRotation)
        {
            var numberOfRotations = (relativeCharShift / charsInRotation);
            var rotationAdjustedCharShift = charShift - numberOfRotations * charsInRotation;
            return (char) (c + rotationAdjustedCharShift);
        }
        return (char) (c + charShift);
    }
}