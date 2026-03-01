using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Services.StringManipulationServices;

public class FirstNonRepeatingCharService
{
    
    public ResponseWrapper<string> GetFirstNonRepeatingChar(string userInput)
    {
        // Visit each item of the list once
       foreach(var item in userInput)
       {
           if (userInput.Where(listItem => listItem == item).Count() == 1)
           {
               return new ResponseWrapper<string>()
               {
                   ResponseCode = ResponseCode.OK,
                   Value = item.ToString(),
               };
           }
       }

       return new ResponseWrapper<string>()
       {
           ResponseCode = ResponseCode.NotFound
       };
    }
    
}