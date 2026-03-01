using InterviewPractice.App.Contracts;
using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Services.OOPServices;

public class ScanToPayService : PaymentBase
{
    public override PaymentMethod PaymentMethod { get;} = PaymentMethod.ScanToPay;
    
    // Common logic, same exact implementation used in other payment service
    // public bool InitiatePayment(User user)
    // {
    //     if (user.SessionValid)
    //         return true;
    //
    //     return false;
    // }

    public override void ProcessPayment()
    {
        Console.WriteLine("Scan the QR code with your compliant app");
    }
}