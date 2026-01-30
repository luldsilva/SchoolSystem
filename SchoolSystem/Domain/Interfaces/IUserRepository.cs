using SchoolSystem.Domain.Entities;

namespace SchoolSystem.Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetByCredentials(string userName, string password);
    }
}
