using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
        => str.Substring(str.IndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string str, string start, string end) 
        => str.Split(start)[1].Split(end)[0];

    public static string Message(this string str)
        => str.Split("]: ")[1];

    public static string LogLevel(this string str)
        => SubstringBetween(str, "[", "]");
}