public class SpaceAge
{
    private readonly double _ageInSeconds;

    private const double EarthYearInSeconds = 31557600;

    // Length of year relative to Earth
    private const double MercuryOrbitalPeriod = 0.2408467;
    private const double VenusOrbitalPeriod   = 0.61519726;
    private const double MarsOrbitalPeriod    = 1.8808158;
    private const double JupiterOrbitalPeriod = 11.862615;
    private const double SaturnOrbitalPeriod  = 29.447498;
    private const double UranusOrbitalPeriod  = 84.016846;
    private const double NeptuneOrbitalPeriod = 164.79132;
    
    public SpaceAge(double seconds)
    {
        _ageInSeconds = seconds;
    }

    public double OnEarth() => _ageInSeconds / EarthYearInSeconds;

    public double OnMercury() => _ageInSeconds / (EarthYearInSeconds * MercuryOrbitalPeriod);

    public double OnVenus() => _ageInSeconds / (EarthYearInSeconds * VenusOrbitalPeriod);
    
    public double OnMars() => _ageInSeconds / (EarthYearInSeconds * MarsOrbitalPeriod);

    public double OnJupiter() => _ageInSeconds / (EarthYearInSeconds * JupiterOrbitalPeriod);

    public double OnSaturn() => _ageInSeconds / (EarthYearInSeconds * SaturnOrbitalPeriod);

    public double OnUranus() => _ageInSeconds / (EarthYearInSeconds * UranusOrbitalPeriod);

    public double OnNeptune() => _ageInSeconds / (EarthYearInSeconds * NeptuneOrbitalPeriod);
    
}