using AutoMapper;
using StarWarsRepository.Repository;

namespace StarWarsRepository;

public class DtoRepository<T, D> : IDtoRepository<T,D>
{
    private readonly IRepository<T> _repo;
    private readonly IMapper _mapper;

    public DtoRepository(IRepository<T> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<IEnumerable<D>> GetAllAsync()
        => _mapper.Map<List<D>>(await _repo.GetAllAsync());

    public async Task<D> GetByIdAsync(int id)
        => _mapper.Map<D>(await _repo.GetByIdAsync(id));

}
