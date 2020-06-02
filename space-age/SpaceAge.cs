public class SpaceAge
{
    private const double EarthOrbitalPeriod = 31_557_600;
    private const double MercuryOffset = 0.2408467;
    private const double VenusOffset = 0.61519726;
    private const double MarsOffset = 1.8808158;
    private const double JupiterOffset = 11.862615;
    private const double SaturnOffset = 29.447498;
    private const double UranusOffset = 84.016846;
    private const double NeptuneOffset = 164.79132;

    private readonly double EarthAge;

    public SpaceAge(int seconds) => EarthAge = seconds / EarthOrbitalPeriod;

    public double OnEarth() => EarthAge;

    public double OnMercury() => EarthAge / MercuryOffset;

    public double OnVenus() => EarthAge / VenusOffset;

    public double OnMars() => EarthAge / MarsOffset;

    public double OnJupiter() => EarthAge / JupiterOffset;

    public double OnSaturn() => EarthAge / SaturnOffset;

    public double OnUranus() => EarthAge / UranusOffset;

    public double OnNeptune() => EarthAge / NeptuneOffset;
}