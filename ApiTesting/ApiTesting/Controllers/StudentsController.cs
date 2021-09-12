using ApiTesting.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IDictionary<Guid, Student> _studentRecords = new Dictionary<Guid, Student>();
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentRecords.Values;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Student value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
