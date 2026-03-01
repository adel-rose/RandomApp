using InterviewPractice.App.Enums;

namespace InterviewPractice.App.Models;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public BankAccountType AccountType { get; set; }
    public bool SessionValid { get; set; }
}