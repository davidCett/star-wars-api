using Microsoft.AspNetCore.Mvc;
using StarWarsRepository;
using StarWarsRepository.Dto;

namespace StarWarsApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonRepository _repository;

    public PersonController(IPersonRepository rerpo)
    {
        _repository = rerpo;
    }

    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        return Ok(await _repository.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<PersonDto> Get(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
