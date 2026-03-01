using InterviewPractice.App.Contracts;
using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Services.OOPServices;

public abstract class PaymentBase : IPaymentService
{
    public ResponseWrapper<bool> InitiatePayment(User user)
    {
        if (!user.SessionValid)
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.Denied,
                Value = false
            };

        return new ResponseWrapper<bool>()
        {
            ResponseCode = ResponseCode.OK,
            Value = true
        };
    }

    public abstract void ProcessPayment();
    public abstract PaymentMethod PaymentMethod { get; }
}