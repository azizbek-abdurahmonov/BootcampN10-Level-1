using System.Security.AccessControl;
using N24_HT1.Models;

namespace N24_HT1.Services;

public class RegistrationService
{
    public UserService userService;
    public UserCredentialsService userCredentialsService;

    public RegistrationService(UserService userService, UserCredentialsService userCredentialsService)
    {
        this.userService = userService;
        this.userCredentialsService = userCredentialsService;
    }


    public bool Register(string firstName, string lastName, string emailAddress, string password)
    {
        try
        {
            var user = userService.Add(firstName, lastName, emailAddress);
            userCredentialsService.Add(user.Id, password);
            return true;
        }
        catch
        {
            return false;
        }
    }
}