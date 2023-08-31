using TestBackend.Files;
using TestBackend.Models;

namespace TestBackend.Services;

public class UserService : IUserService
{
    private readonly IFileContext _fileContext;

    public UserService()
    {
        _fileContext = new FileContext();
    }

    public User AddUser(User user)
    {
        return _fileContext.AddUser(user);
    }

    public List<User> GetUsers()
    {
        return _fileContext.GetUsers();
    }

    public void DeleteUser(Guid Id)
    {
        _fileContext.DeleteUser(Id);
    }

    public void UpdateUser(User user)
    {
        _fileContext.UpdateUser(user);
    }
}