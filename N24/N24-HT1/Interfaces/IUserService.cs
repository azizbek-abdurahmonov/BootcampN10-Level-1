using N24_HT1.Models;

namespace N24_HT1.Interfaces;

public interface IUserService
{
    public List<User> Get(int pageSize, int pageToken);
    public List<User> Search(string searchKeyword, int pageSize, int pageToken);
    public List<User> Filter(UserFilterModel filter);
    public User Add(string firstName, string lastName, string emailAddress);
    public User Update(User user);
    public void Delete(Guid id);
}