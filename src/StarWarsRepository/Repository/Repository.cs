using Microsoft.EntityFrameworkCore;

namespace StarWarsRepository.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly StarWarsContext.Models.StarWarsContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(StarWarsContext.Models.StarWarsContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
        => await _dbSet.ToListAsync();
}
