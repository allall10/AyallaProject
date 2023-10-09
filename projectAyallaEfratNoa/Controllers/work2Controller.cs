﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectAyallaEfratNoa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class work2Controller : ControllerBase
    {
        // GET: api/<work2Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<work2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<work2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<work2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<work2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
