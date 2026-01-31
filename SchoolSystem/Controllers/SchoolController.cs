using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Application.Services;
using SchoolSystem.Domain.Entities;

namespace SchoolSystem.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/schools")]
    public class SchoolController(SchoolService service) : ControllerBase
    {
        private readonly SchoolService _service = service;

        [HttpGet]
        public IActionResult Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var allSchools = _service.GetAll();
            var totalItems = allSchools.Count();

            var pagedSchools = allSchools
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Ok(new
            {
                data = pagedSchools,
                page,
                pageSize,
                totalItems
            });
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var allSchools = _service.GetAll();
            return Ok(allSchools);
        }


        [HttpPost]
        public IActionResult Post([FromBody] School school)
        {
            _service.Create(school);
            return Ok(school);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] School school)
        {
            school.Id = id;
            _service.Update(school);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
