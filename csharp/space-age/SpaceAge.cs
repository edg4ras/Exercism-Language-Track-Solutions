using System;

public class SpaceAge
{
    private int _seconds;
    private double _earthOrbitalPeriod;
    
    public SpaceAge(int seconds)
    {
        _earthOrbitalPeriod = 31557600;
        _seconds = seconds;
    }

    public double OnEarth() => _seconds / _earthOrbitalPeriod;

    public double OnMercury() => InRelationTo(0.2408467);

    public double OnVenus() => InRelationTo(0.61519726);

    public double OnMars() => InRelationTo(1.8808158);

    public double OnJupiter() => InRelationTo(11.862615);

    public double OnSaturn() => InRelationTo(29.447498);

    public double OnUranus() => InRelationTo(84.016846);

    public double OnNeptune() => InRelationTo(164.79132);

    private double InRelationTo(double ratio)
    {
        var orbitalPeriod = (_earthOrbitalPeriod * ratio);
        return _seconds / orbitalPeriod;
    }
}