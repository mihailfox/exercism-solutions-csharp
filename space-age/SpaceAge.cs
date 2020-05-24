public class SpaceAge
{
    private readonly int _seconds;
    
    private const double _earth_orbital_period = 31_557_600;
    private const double _mercury_offset = 0.2408467;
    private const double _venus_offset = 0.61519726;
    private const double _mars_offset = 1.8808158;
    private const double _jupiter_offset = 11.862615;
    private const double _saturn_offset = 29.447498;
    private const double _uranus_offset = 84.016846;
    private const double _neptune_offset = 164.79132;

    private double _on_earth;

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
        _on_earth = _seconds / _earth_orbital_period;
    }

    public double OnEarth() => _on_earth;

    public double OnMercury() => _on_earth / _mercury_offset;
    public double OnVenus() => _on_earth / _venus_offset;
    public double OnMars() => _on_earth / _mars_offset;
    public double OnJupiter() => _on_earth / _jupiter_offset;
    public double OnSaturn() => _on_earth / _saturn_offset;
    public double OnUranus() => _on_earth / _uranus_offset;
    public double OnNeptune() => _on_earth / _neptune_offset;

}