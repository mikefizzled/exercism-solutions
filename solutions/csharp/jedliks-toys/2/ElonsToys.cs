using System;

class RemoteControlCar {
  private double _distance;
  private double _battery = 100;
  public static RemoteControlCar Buy() => new RemoteControlCar();

  public string DistanceDisplay() => $"Driven {_distance.ToString()} meters";

  public string BatteryDisplay() => _battery > 0 ? $"Battery at {Math.Round(_battery, 1).ToString()}%" : "Battery empty";


  public void Drive() {
    if (_battery > 0) {
      _distance += 20;
      _battery--;
      DistanceDisplay();
    }
  }
}