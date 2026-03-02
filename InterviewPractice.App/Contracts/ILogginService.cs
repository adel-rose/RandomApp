using InterviewPractice.App.Enums;

namespace InterviewPractice.App.Contracts;

public interface ILogginService
{
    public UserType Type { get; }
    public void Login();
}