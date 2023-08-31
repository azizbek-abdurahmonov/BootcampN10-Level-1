using TestBackend.Models;

namespace TestBackend.Services;

public interface IUserService
{
    User AddUser(User user);
    List<User> GetUsers();
    void DeleteUser(Guid Id);
    void UpdateUser(User user);
}