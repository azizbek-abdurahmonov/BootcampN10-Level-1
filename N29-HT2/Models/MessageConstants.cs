namespace N29_HT2.Models;

public class MessageConstants
{
    public const string ConfirmationSubject = "Confirm Your Email Address";
    
    public const string ConfirmationMessage = @"Dear {{Employee}},

    Thank you for joining the team. To start your journey we need to first confirm your email address, please click on the following link to confirm your email address:

    If you received this email mistakenly, please ignore this email.

        Thank you";

    public const string WelcomeOnBoardSubject = "Welcome to Gishtmat's Company";

    public const string WelcomeOnBoardMessage = @"Dear {{Employee}},

    We are thrilled to welcome you! We are excited to have you on board and look forward to working with you.

        As a new member of our team, we want to make sure you have everything you need to get started. Please let us know if you have any questions or need any assistance.

        We wish you all the best in your new role and look forward to your contributions to our team.

        Best regards";

    public const string OfficePoliciesSubject = "Office Policies and Guidelines";

    public const string OfficePoliciesBody = @"Dear {{Employee}},

    As a member of our team, it is important that you are aware of our office policies and guidelines. These policies are designed to ensure a safe and productive work environment for everyone.

        Please take a moment to review the attached document, which outlines our policies and guidelines. If you have any questions or concerns, please do not hesitate to reach out to us.

        Thank you for your cooperation and adherence to our policies.

        Best regards";
}