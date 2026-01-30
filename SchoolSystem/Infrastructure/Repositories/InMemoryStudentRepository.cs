using SchoolSystem.Domain.Entities;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new();

        public IEnumerable<Student> GetAll() => _students;

        public Student GetById(int id) =>
            _students.FirstOrDefault(s => s.Id == id);

        public void Add(Student student)
        {
            student.Id = _students.Count + 1;
            _students.Add(student);
        }

        public void Update(Student student)
        {
            var existing = GetById(student.Id);
            if (existing == null) return;

            existing.Name = student.Name;
            existing.BirthDate = student.BirthDate;
            existing.Cpf = student.Cpf;
            existing.Address = student.Address;
            existing.MobilePhone = student.MobilePhone;
            existing.SchoolId = student.SchoolId;
        }

        public void Delete(int id)
        {
            var student = GetById(id);
            if (student != null)
                _students.Remove(student);
        }
    }
}
