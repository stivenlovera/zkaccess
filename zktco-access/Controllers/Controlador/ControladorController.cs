using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zktco_access.Controllers.Controlador
{
    [Route("api/controlador")]
    [ApiController]
    public class ControladorController : ControllerBase
    {
        // GET: api/<ControladorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ControladorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ControladorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ControladorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ControladorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
