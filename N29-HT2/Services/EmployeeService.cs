using System.Net;
using System.Net.Mail;
using System.Text;
using N29_HT2.Models;

namespace N29_HT2.Services;

public class EmployeeService
{
    private EmailService _emailService;

    public EmployeeService()
    {
        _emailService = new EmailService();
    }

    public async Task HireAsync(Employee employee)
    {
        string fullName = $"{employee.FirstName} {employee.LastName}";
        string path = $"{employee.FirstName} {employee.LastName}`s employment contract.docx";

        //Confirmation email jo'natish
        var firstEmailTask = Task.Run(async () =>
        {
            return await _emailService.SendAsync(employee.EmailAddress, MessageConstants.ConfirmationSubject,
                MessageConstants.ConfirmationMessage, fullName);
        });

        //Fayl yaratish
        var createFile = Task.Run(() =>
        {
            var res = File.Create(path);
            res.Close();
            return res;
        });

        //Confirmation email jo'natib bo'lingach Welcome on board emailin jo'natish
        await firstEmailTask;
        var secondEmailTask = Task.Run(async () =>
        {
            return await _emailService.SendAsync(employee.EmailAddress, MessageConstants.WelcomeOnBoardSubject,
                MessageConstants.WelcomeOnBoardMessage, fullName);
        });

        //Fayl yaratib bo'lingach ichiga "employment contract" textini yozish
        var fileStream = await createFile;
        await File.WriteAllTextAsync(path, "employment contract");

        await secondEmailTask;
        await _emailService.SendAsync(employee.EmailAddress, MessageConstants.OfficePoliciesSubject,
            MessageConstants.OfficePoliciesBody, fullName);
    }
}