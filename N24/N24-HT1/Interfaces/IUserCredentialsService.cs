using N24_HT1.Models;

namespace N24_HT1.Interfaces;

public interface IUserCredentialsService
{
    public UserCredentials Add(Guid userId, string password);
    public UserCredentials GetByUserId(Guid userId);
    
    
}