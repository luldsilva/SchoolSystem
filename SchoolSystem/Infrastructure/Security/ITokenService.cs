namespace SchoolSystem.Infrastructure.Security
{
    public interface ITokenService
    {
        string GenerateToken(string userName);
    }
}
