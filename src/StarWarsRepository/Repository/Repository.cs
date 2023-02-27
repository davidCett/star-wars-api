using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;

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

    public async Task<T> GetByIdAsync(int id)
        => await _dbSet.FindAsync(id);
}
