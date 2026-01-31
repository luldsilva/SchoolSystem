using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Application.Services;
using SchoolSystem.Domain.Entities;

namespace SchoolSystem.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/students")]
    public class StudentController(StudentService service) : ControllerBase
    {
        private readonly StudentService _service = service;

        [HttpGet]
        public IActionResult Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var allStudents = _service.GetAll();
            var totalItems = allStudents.Count();

            var pagedStudents = allStudents
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Ok(new
            {
                data = pagedStudents,
                page,
                pageSize,
                totalItems
            });
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _service.Create(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            student.Id = id;
            _service.Update(student);
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
