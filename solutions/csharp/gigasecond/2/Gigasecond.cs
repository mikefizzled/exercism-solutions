using System;

public static class Gigasecond
{
    const double GIGASECOND = 1e9;
    
    public static DateTime Add(DateTime moment)
    {
        DateTime newTime = moment.AddSeconds(GIGASECOND);
        return newTime;
    }
}