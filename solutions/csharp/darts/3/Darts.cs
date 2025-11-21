using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double combined = x * x + y * y;
        double distance = Math.Sqrt(combined);

        if(distance > 10)
            return 0;
        else if (distance > 5)
            return 1;
        else if (distance > 1)
            return 5;
        else if (distance >= 0)
            return 10;
        else
            return 0;
    }
}
