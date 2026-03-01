using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Contracts;

public interface IPaymentService
{
    PaymentMethod PaymentMethod { get;}
    ResponseWrapper<bool> InitiatePayment(User user);
    void ProcessPayment();
}