using System.Text.Json;
using TestBackend.Models;

namespace TestBackend.Files;

public class FileContext : IFileContext
{
    private string _filePath = @"D:\PROJECTS\BootcampN10-Level-1\TestBackend\DataLayer\users.txt";
    public User AddUser(User user)
    {
        if (File.ReadAllText(_filePath).Length == 0)
        {
            File.WriteAllText(_filePath, JsonSerializer.Serialize(new List<User> { user }));
        }
        else
        {
            var users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(_filePath));
            users.Add(user);
            File.WriteAllText(_filePath, JsonSerializer.Serialize(users));
        }
        return user;
    }


    public List<User> GetUsers()
    {
        if (File.ReadAllText(_filePath).Length == 0)
            return new List<User>();

        return JsonSerializer.Deserialize<List<User>>(File.ReadAllText(_filePath));
    }

    public void DeleteUser(Guid Id)
    {
        var users = GetUsers();
        users.Remove(users.FirstOrDefault(x => x.Id == Id));
        File.WriteAllText(_filePath, JsonSerializer.Serialize(users));
    }

    public void UpdateUser(User user)
    {
        var users = GetUsers();
        var oldUser = users.FirstOrDefault(x => x.Id == user.Id);

        oldUser.Name = user.Name;
        oldUser.Age = user.Age;
        File.WriteAllText(_filePath, JsonSerializer.Serialize(users));

    }

}