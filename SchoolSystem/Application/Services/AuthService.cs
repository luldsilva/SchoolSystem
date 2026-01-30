using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Infrastructure.Security;

namespace SchoolSystem.Application.Services
{
    public class AuthService(
        IUserRepository userRepository,
        ITokenService tokenService)
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly ITokenService _tokenService = tokenService;

        public string? Login(string userName, string password)
        {
            var user = _userRepository.GetByCredentials(userName, password);

            if (user == null)
                return null;

            return _tokenService.GenerateToken(user.UserName);
        }
    }
}