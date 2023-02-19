using Microsoft.EntityFrameworkCore;
using StarWarsContext.Models;

namespace StarWarsRepository;

public class PersonRepository : IPersonRepository
{
    private readonly StarWarsContext.Models.StarWarsContext _context;
    private readonly DbSet<Person> _persons;

    public PersonRepository(StarWarsContext.Models.StarWarsContext context)
    {
        _context = context;
        _persons = _context.Set<Person>();
    }

    public async Task<IEnumerable<Person>> GetAllAsync()
    {
        return await _persons.ToListAsync();
    }
}
