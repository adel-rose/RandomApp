using InterviewPractice.App.Contracts;
using InterviewPractice.App.Enums;

namespace InterviewPractice.App.Services.OOPServices;

public class IndividualLoginService : ILogginService
{
    public UserType Type { get; private set; } = UserType.Individual;
    
    public void Login()
    {
       Console.WriteLine("Individual logged in");
    }
}