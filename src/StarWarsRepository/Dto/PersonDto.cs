using StarWarsContext.Models;

namespace StarWarsRepository.Dto;

public class PersonDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? Height { get; set; }
    public double? Mass { get; set; }
    public string? HairColor { get; set; }
    public string? SkinColor { get; set; }
    public string? EyeColor { get; set; }
    public string? BirthYear { get; set; }
    public string? Gender { get; set; }
    public string? Url { get; set; }
}
