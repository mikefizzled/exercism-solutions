using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime newTime = moment.AddSeconds(1000000000);
        return newTime;
    }
}