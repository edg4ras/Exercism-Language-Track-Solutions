using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        if (Enum.TryParse<Color>(color, true, out var colorCode))
            return (int) colorCode;
        return -1;
    }

    public static string[] Colors()
    {
        var names = Enum.GetNames(typeof(Color));
        return Array.ConvertAll(names, x => x.ToLowerInvariant());
    }
}

public enum Color
{
    Black = 0,
    Brown = 1,
    Red = 2,
    Orange = 3,
    Yellow = 4,
    Green = 5,
    Blue = 6,
    Violet = 7,
    Grey = 8,
    White = 9 
}