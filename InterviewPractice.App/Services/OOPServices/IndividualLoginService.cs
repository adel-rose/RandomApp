using InterviewPractice.App.Contracts;
using InterviewPractice.App.Enums;

namespace InterviewPractice.App.Services.OOPServices;

public class IndividualLoginService : ILogginService
{
    public UserType Type { get; private set; } = UserType.Individual;
    
    public bool Login(UserType type)
    {
        if (type == UserType.Individual)
            return true;

        return false;
    }
}