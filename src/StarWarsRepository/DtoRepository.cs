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
        => _mapper.Map<IEnumerable<D>>(await _repo.GetAllAsync());

}
