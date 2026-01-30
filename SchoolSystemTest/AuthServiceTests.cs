using Moq;
using SchoolSystem.Application.Services;
using SchoolSystem.Domain.Interfaces;
using SchoolSystem.Domain.Entities;
using SchoolSystem.Infrastructure.Security;

namespace SchoolSystemTest
{
    public class AuthServiceTests
    {
        [Fact]
        public void Login_WithValidCredentials_ShouldReturnToken()
        {
            // Arrange

            // Mock do repositório
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock
                .Setup(r => r.GetByCredentials("TESTE", "123"))
                .Returns(new User
                {
                    UserName = "TESTE",
                    Password = "123"
                });

            // Mock do TokenService
            var tokenServiceMock = new Mock<ITokenService>();
            tokenServiceMock
                .Setup(t => t.GenerateToken(It.IsAny<string>()))
                .Returns("fake-token");

            var authService = new AuthService(
                userRepositoryMock.Object,
                tokenServiceMock.Object
            );

            // Act
            var token = authService.Login("TESTE", "123");

            // Assert
            Assert.Equal("fake-token", token);
        }

        [Fact]
        public void Login_WithInvalidCredentials_ShouldReturnNull()
        {
            // Arrange
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock
                .Setup(r => r.GetByCredentials(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((User?)null);

            var tokenServiceMock = new Mock<TokenService>(null);

            var authService = new AuthService(
                userRepositoryMock.Object,
                tokenServiceMock.Object
            );

            // Act
            var token = authService.Login("INVALID", "WRONG");

            // Assert
            Assert.Null(token);
        }
    }
}