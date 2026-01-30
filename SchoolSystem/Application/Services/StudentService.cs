using SchoolSystem.Domain.Entities;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Application.Services
{
    public class StudentService(IStudentRepository repository)
    {
        private readonly IStudentRepository _repository = repository;

        public IEnumerable<Student> GetAll() => _repository.GetAll();
        public void Create(Student student) => _repository.Add(student);
        public void Update(Student student) => _repository.Update(student);
        public void Delete(int id) => _repository.Delete(id);
    }
}
