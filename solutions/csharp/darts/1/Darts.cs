using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
        double root = Math.Sqrt(distance);

        if(root > 10)
            return 0;
        else if (root <= 10 && root > 5)
            return 1;
        else if (root <= 5  && root > 1)
            return 5;
        else if (root <= 1 && root >= 0)
            return 10;
        else
            return 0;
    }
}
