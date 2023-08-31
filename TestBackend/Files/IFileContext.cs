using TestBackend.Models;

namespace TestBackend.Files;

public interface IFileContext
{
    User AddUser(User user);
    List<User> GetUsers();
    void DeleteUser(Guid Id);
    void UpdateUser(User user);
}