using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Services.OOPServices;

public class Bank
{
    public bool loggedIn;
    private decimal balance = 9999.99m;

    public void HeartBeat(bool SessionValid) => loggedIn = SessionValid;
    
    public ResponseWrapper<decimal> Balance
    {
        get
        {
            if (loggedIn)
                return new ResponseWrapper<decimal>()
                {
                    ResponseCode = ResponseCode.OK,
                    Value = balance
                };

            return new ResponseWrapper<decimal>()
            {
                ResponseCode = ResponseCode.Denied
            };
        }
    }
    
    
}