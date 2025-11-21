using System;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _distanceDriven;
    private int _batteryRemaining;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
        this._distanceDriven = 0;
        this._batteryRemaining = 100;
    }
    
    public bool BatteryDrained() => _batteryRemaining < _batteryDrain;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if(!BatteryDrained())
        {
            _distanceDriven += _speed;
            _batteryRemaining -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _trackDistance;
    
    public RaceTrack(int distance)
    {
        this._trackDistance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        int finalDistance = car.DistanceDriven() + _trackDistance;
        
        while (car.DistanceDriven() <= finalDistance)
        {
            if(car.BatteryDrained())
                break;
            else
                car.Drive();
        }
        return car.DistanceDriven() >= finalDistance; 
    }

}
