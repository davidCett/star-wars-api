namespace StarWarsRepository.Repository;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAllAsync();
}
