using System;
using System.Collections.Generic;

public class Robot
{
    private string _name;
    
    public Robot() => _name = RobotNameGenerator.GetName();

    public string Name
    {
        get { return _name; }
    }

    public void Reset() => _name = RobotNameGenerator.GetName();
}

public static class RobotNameGenerator 
{
    private static Random _random = new Random();
    private static HashSet<string> _nameRegistry = new HashSet<string>();

    public static string GetName() {
        string name = default;
        
        do name = GenerateName();
        while (!_nameRegistry.Add(name));

        return name;
    }

    private static string GenerateName() => $"{GetLetter()}{GetLetter()}{GetNumber()}{GetNumber()}{GetNumber()}";
    private static char GetLetter() => (char) _random.Next('A', 'Z');
    private static int GetNumber() => _random.Next(0, 9);
}