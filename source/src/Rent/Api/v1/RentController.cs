// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api.v1
{
    using CarRent.Car.Domain;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/v1/car")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly ICarRepository _repository;

        public RentController(ICarRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<CarController>
        [HttpGet]
        public IActionResult Get()
        {
            var reservations = _repository.GetAll();
            var rentDtos = reservations.Select(r => new RentResponseDto(r));
            return Ok(rentDtos);

        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
