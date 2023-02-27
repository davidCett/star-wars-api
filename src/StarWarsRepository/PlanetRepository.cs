using AutoMapper;
using StarWarsContext.Models;
using StarWarsRepository.Dto;
using StarWarsRepository.Repository;

namespace StarWarsRepository;

public class PlanetRepository : DtoRepository<Planet, PlanetDto>, IPlanetRepository
{
    public PlanetRepository(IRepository<Planet> context, IMapper mapper) : base(context, mapper)
    {

    }
}
