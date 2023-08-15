using System.Text.RegularExpressions;
using N24_HT1.Interfaces;
using N24_HT1.Models;

namespace N24_HT1.Services;

public class UserCredentialsService : IUserCredentialsService
{
    private List<UserCredentials> _userCredentials;

    public UserCredentialsService() => _userCredentials = new List<UserCredentials>();

    public UserCredentials Add(Guid userId, string password)
    {
        if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"))
        {
            var userCredentials = new UserCredentials(password, userId);
            _userCredentials.Add(userCredentials);
            return userCredentials;
        }

        throw new Exception("Password is not valid or string");
    }

    public UserCredentials GetByUserId(Guid userId)
    {
        return _userCredentials.Any(c => c.userId == userId)
            ? _userCredentials.Find(c => c.userId == userId)
            : null;
    }
}