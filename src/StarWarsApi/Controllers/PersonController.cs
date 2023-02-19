using Microsoft.AspNetCore.Mvc;
using StarWarsContext.Models;
using StarWarsRepository;

namespace StarWarsApi.Controllers
{

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
        public async Task<IEnumerable<Person>> Get()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
}
