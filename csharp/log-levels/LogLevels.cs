using System;

static class LogLine
{
    const string Error = "[ERROR]:";
    const string Warning = "[WARNING]:";
    const string Info = "[INFO]:";

    public static string Message(string logLine) => logLine
        .Replace(Error, string.Empty)
        .Replace(Warning, string.Empty)
        .Replace(Info, string.Empty)
        .TrimStart().TrimEnd();

    public static string LogLevel(string logLine)
    {
        if (logLine.StartsWith(Error))
            return "error";

        if (logLine.StartsWith(Warning))
            return "warning";

        if (logLine.StartsWith(Info))
            return "info";

        throw new ArgumentException(nameof(logLine));
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
