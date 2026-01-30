using SchoolSystem.Domain.Entities;

namespace SchoolSystem.Domain.Interfaces
{
    public interface ISchoolRepository
    {
        IEnumerable<School> GetAll();
        School GetById(int id);
        void Add(School school);
        void Update(School school);
        void Delete(int id);
    }
}
