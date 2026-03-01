using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Services.StringManipulationServices;

public class PalindromeService
{
    public ResponseWrapper<bool> IsPalindrome(string userInput)
    {
        if (userInput == null)
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.BadRequest,
                Value = false
            };
        
        var reversedUserInput = new List<char>();

        for(int i = userInput.Length - 1; i >= 0; i--)
        {
            reversedUserInput.Add(userInput[i]);
        }
        
        var isPalindrome = userInput.Equals(new string(reversedUserInput.ToArray()), StringComparison.OrdinalIgnoreCase);
        
        return new ResponseWrapper<bool>()
        {
            ResponseCode = ResponseCode.OK,
            Value = isPalindrome
        };
    }
    
    public ResponseWrapper<bool> IsPalindromeUsingReverse(string userInput)
    {
        if (userInput == null)
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.BadRequest,
                Value = false
            };
        
        var reversedUserInput = new string(userInput.Reverse().ToArray());
        
        var isPalindrome = userInput.Equals(reversedUserInput, StringComparison.OrdinalIgnoreCase);
        
        return new ResponseWrapper<bool>()
        {
            ResponseCode = ResponseCode.OK,
            Value = isPalindrome
        };
    }
}