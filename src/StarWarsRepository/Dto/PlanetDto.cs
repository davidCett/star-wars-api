namespace StarWarsRepository.Dto;

public class PlanetDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? RotationPeriod { get; set; }
    public int? OrbitalPeriod { get; set; }
    public int? Diameter { get; set; }
    public string? Climate { get; set; }
    public string? Gravity { get; set; }
    public string? Terrain { get; set; }
    public string? SurfaceWater { get; set; }
    public long? Population { get; set; }
    public string? Url { get; set; }
}
