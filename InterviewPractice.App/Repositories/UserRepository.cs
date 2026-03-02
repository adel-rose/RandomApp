using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Repositories;

public class UserRepository
{
    public ResponseWrapper<List<User>> GetUsers()
    {
        var inMemoryDataSet = new List<User>()
        {
            new User()
            {
                FirstName = "John",
                LastName = "Doe",
                AccountType = BankAccountType.Savings,
                SessionValid = true,
                PaymentMethod = PaymentMethod.ScanToPay
                
            },
            new User()
            {
                FirstName = "Jane",
                LastName = "Doe",
                AccountType = BankAccountType.Current,
                SessionValid = false,
                PaymentMethod = PaymentMethod.SecurePage
            }
        };

        return new ResponseWrapper<List<User>>()
        {
            ResponseCode = ResponseCode.OK,
            Value = inMemoryDataSet
        };
    }

}