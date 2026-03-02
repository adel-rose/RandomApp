using InterviewPractice.App.Contracts;
using InterviewPractice.App.Enums;

namespace InterviewPractice.App.Services.OOPServices;

public class CorporateLoginService : ILogginService
{
    public UserType Type { get; private set; } = UserType.Corporate;
    
    public void Login()
    {
        Console.WriteLine("Corporate logged in");
    }
}