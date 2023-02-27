namespace StarWarsRepository;

public interface IDtoRepository<T,D>
{
    Task<IEnumerable<D>> GetAllAsync();
    Task<D> GetByIdAsync(int id);
}