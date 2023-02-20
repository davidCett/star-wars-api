using StarWarsContext.Models;
using StarWarsRepository.Dto;

namespace StarWarsRepository;

public interface IPersonRepository : IDtoRepository<Person, PersonDto>
{
}
