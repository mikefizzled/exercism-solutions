using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double success;
        if(speed == 0)
            success = 0;
        else if(speed >= 1 && speed <= 4)
            success = 1;
        else if(speed >= 5 && speed <= 8)
            success = 0.9;
        else if(speed == 9)
            success = 0.8;
        else if(speed == 10)
            success = 0.77;
        else 
            success = 0;
        return success;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int linearRate = 221;
        return (linearRate * SuccessRate(speed) * speed);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
