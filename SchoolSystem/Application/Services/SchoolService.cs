using SchoolSystem.Domain.Entities;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Application.Services
{
    public class SchoolService(ISchoolRepository repository)
    {
        private readonly ISchoolRepository _repository = repository;

        public IEnumerable<School> GetAll()
            => _repository.GetAll();

        public School GetById(int id)
            => _repository.GetById(id);

        public void Create(School school)
            => _repository.Add(school);

        public void Update(School school)
            => _repository.Update(school);

        public void Delete(int id)
            => _repository.Delete(id);
    }
}
