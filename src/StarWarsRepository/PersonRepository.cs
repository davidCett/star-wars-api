using AutoMapper;
using StarWarsContext.Models;
using StarWarsRepository.Dto;
using StarWarsRepository.Repository;

namespace StarWarsRepository;

public class PersonRepository : DtoRepository<Person, PersonDto>, IPersonRepository
{
    public PersonRepository(IRepository<Person> context, IMapper mapper) : base(context, mapper)
    {

    }
}
