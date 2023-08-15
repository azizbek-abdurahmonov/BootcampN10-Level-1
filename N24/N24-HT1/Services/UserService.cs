using System.Formats.Tar;
using System.Text;
using N24_HT1.Interfaces;
using N24_HT1.Models;

namespace N24_HT1.Services;

public class UserService : IUserService
{
    private List<User> _users;

    public UserService() => _users = new List<User>();


    public List<User> Get(int pageSize, int pageToken)
    {
        return _users.Where(user => !user.isDeleted).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
    }

    public List<User> Search(string searchKeyword, int pageSize, int pageToken)
    {
        return _users.Where(
            user => !user.isDeleted
                    && user.firstName.ToLower().Contains(searchKeyword.ToLower())
                    || user.lastName.ToLower().Contains(searchKeyword.ToLower())
                    || user.emailAddress.ToLower().Contains(searchKeyword.ToLower())
        ).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
    }

    public List<User> Filter(UserFilterModel filter)
    {
        return _users.Where(user => !user.isDeleted
                                    && (filter.firstName is null || filter.firstName.Equals(user.firstName))
                                    && (filter.lastName is null || filter.lastName.Equals(user.lastName)))
            .Skip((filter.pageToken - 1) * filter.pageSize).Take(filter.pageSize)
            .ToList();
    }

    public User Add(string firstName, string lastName, string emailAddress)
    {
        if (!(_users.Any(u => u.emailAddress == emailAddress)))
        {
            var user = new User(firstName, lastName, emailAddress);
            _users.Add(user);
            return user;
        }

        throw new Exception("User isn't unique");
    }

    public User Update(User user)
    {
        if (_users.Any(u => u.Id == user.Id))
        {
            var newUser = _users.Find(u => u.Id == user.Id);
            newUser.firstName = user.firstName;
            newUser.lastName = user.lastName;
            newUser.emailAddress = user.emailAddress;
            return newUser;
        }

        throw new Exception("User not found");
    }

    public void Delete(Guid id)
    {
        if (_users.Any(user => user.Id == id))
        {
            var user = _users.Find(user => user.Id == id);
            user.isDeleted = true;
        }
        else
            throw new Exception("User not found");
    }
    
    
}