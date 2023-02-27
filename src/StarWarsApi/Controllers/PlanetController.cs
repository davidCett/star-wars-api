using Microsoft.AspNetCore.Mvc;
using StarWarsRepository;
using StarWarsRepository.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarWarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {

        private readonly IPlanetRepository _repository;

        public PlanetController(IPlanetRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<PlanetController>
        [HttpGet]
        public async Task<IEnumerable<PlanetDto>> Get()
        {
            return await _repository.GetAllAsync();
        }

        // GET api/<PlanetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlanetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlanetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlanetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
