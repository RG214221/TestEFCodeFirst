using Microsoft.AspNetCore.Mvc;
using TestEFCodeFirst;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeopleAndTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tasks : ControllerBase
    {
        private readonly Context _context = new Context();
        // GET: api/<Tasks>
        [HttpGet]
        public IEnumerable<TaskToDo> Get()
        {
            return _context.TasksToDo.ToList();
        }

        // GET api/<Tasks>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Tasks>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Tasks>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Tasks>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
