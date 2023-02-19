using StarWarsContext.Models;

namespace StarWarsRepository;

public interface IPersonRepository
{
    Task<IEnumerable<Person>> GetAllAsync();
}
