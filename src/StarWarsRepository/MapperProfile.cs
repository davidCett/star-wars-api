using AutoMapper;
using StarWarsContext.Models;
using StarWarsRepository.Dto;

namespace StarWarsRepository;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Person, PersonDto>();
        CreateMap<Planet, PlanetDto>();
    }
}
