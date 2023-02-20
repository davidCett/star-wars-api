namespace StarWarsRepository;

public interface IDtoRepository<T,D>
{
    Task<IEnumerable<D>> GetAllAsync();
}