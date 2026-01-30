using SchoolSystem.Domain.Entities;
using SchoolSystem.Domain.Interfaces;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static readonly List<User> _users = new()
    {
        new User
        {
            Id = 1,
            UserName = "TESTE",
            Password = "123"
        }
    };

        public User GetByCredentials(string userName, string password)
        {
            return _users.FirstOrDefault(u =>
                u.UserName == userName && u.Password == password);
        }
    }
}
