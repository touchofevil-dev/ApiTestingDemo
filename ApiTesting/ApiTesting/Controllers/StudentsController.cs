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
        private static IDictionary<Guid, Student> _studentRecords = DataProvider.GetInitialStudentData();

        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentRecords.Values;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            if (_studentRecords.ContainsKey(id))
            {
                return Ok(_studentRecords[id]);
            }
            return NotFound();
        }

        // POST api/<StudentsController>
        [HttpPost]
        public IActionResult Post([FromBody] Student requestModel)
        {
            if (_studentRecords.ContainsKey(requestModel.Id))
            {
                return Conflict();
            }
            _studentRecords.Add(requestModel.Id, requestModel);
            return CreatedAtAction("Get", requestModel);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Student requestModel)
        {
            if (_studentRecords.ContainsKey(id))
            {
                _studentRecords[id] = requestModel;
                return NoContent();
            }
            return NotFound();
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (_studentRecords.ContainsKey(id))
            {
                _studentRecords.Remove(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
