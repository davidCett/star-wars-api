using StarWarsContext.Models;
using StarWarsRepository.Dto;

namespace StarWarsRepository;

public interface IPlanetRepository : IDtoRepository<Planet, PlanetDto>
{
}
