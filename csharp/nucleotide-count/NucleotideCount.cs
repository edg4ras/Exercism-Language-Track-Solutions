using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var count = new Dictionary<char, int>{
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T', 0 }
        };

        foreach (var element in sequence)
            if (count.TryGetValue(element, out var currentCount))
                count[element] = ++currentCount;
            else
                throw new ArgumentException($"Invalid nucloetide {element}", nameof(sequence));

        return count;
    }
}