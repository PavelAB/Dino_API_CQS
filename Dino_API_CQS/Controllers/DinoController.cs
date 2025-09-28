using Dino_API_CQS.Mappers;
using Dino_API_CQS.Models.Dino;
using Dino_API_Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dino_API_CQS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinoController : ControllerBase
    {
        private readonly IDinoRepository _dinoRepository;

        public DinoController(IDinoRepository dinoRepository)
        {
            _dinoRepository = dinoRepository;
        }

        // GET: api/<DinoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DinoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DinoController>
        [HttpPost]
        public IActionResult Create(DinoCreate entity)
        {
            return Ok(_dinoRepository.Execute(entity.ToCreateDinoCommand()));
        }

        // PUT api/<DinoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DinoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
