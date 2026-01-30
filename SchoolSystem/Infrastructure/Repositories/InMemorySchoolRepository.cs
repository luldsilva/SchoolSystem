using SchoolSystem.Domain.Entities;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class InMemorySchoolRepository : ISchoolRepository
    {
        private static readonly List<School> _schools = new();

        public IEnumerable<School> GetAll() => _schools;

        public School GetById(int id) =>
            _schools.FirstOrDefault(s => s.Id == id);

        public void Add(School school)
        {
            school.Id = _schools.Count + 1;
            _schools.Add(school);
        }

        public void Update(School school)
        {
            var existing = GetById(school.Id);
            if (existing == null) return;

            existing.Description = school.Description;
        }

        public void Delete(int id)
        {
            var school = GetById(id);
            if (school != null)
                _schools.Remove(school);
        }
    }
}
