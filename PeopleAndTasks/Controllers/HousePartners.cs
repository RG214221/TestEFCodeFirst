using Microsoft.AspNetCore.Mvc;
using TestEFCodeFirst;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeopleAndTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousePartners : ControllerBase
    {
        private readonly Context _context = new Context();
        // GET: api/<HousePartners>
        [HttpGet("api/GETActivePartnerController")]
        public IEnumerable<ActivePartner> Get()
        {
            return _context.ActivePartners.ToList();
        }

        // GET api/<HousePartners>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HousePartners>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HousePartners>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HousePartners>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("api/GetActivePartner{id}")]
        public List<ActivePartner> action(int id)
        {
            List<ActivePartner> res= new List<ActivePartner>();
            foreach (var item in _context.ActivePartners)
            {
                if(item.PersonId== id)
                res.Add(item);  
            }
            return res;
        }
        
    }
}
