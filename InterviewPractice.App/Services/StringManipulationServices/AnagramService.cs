using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;

namespace InterviewPractice.App.Services.StringManipulationServices;

public class AnagramService
{
    private List<char> _userInput1, _userInput2;
    
    public ResponseWrapper<bool> AreAnagrams(string userInput1, string userInput2)
    {
        _userInput1 = userInput1.OrderBy(x => x).ToList();
        _userInput2 = userInput2.OrderBy(x => x).ToList();

        if (_userInput1 is null || _userInput2 is null)
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.BadRequest
            };

        if (_userInput1.Count != _userInput2.Count)
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.OK,
                Value = false
            };
        
        // check if both have the exact same content

        for (int i = 0; i < _userInput1.Count; i++)
        {
            if (_userInput1[i] != _userInput2[i])
                return new ResponseWrapper<bool>()
                {
                    ResponseCode = ResponseCode.OK,
                    Value = false
                };
        }
        
        return new ResponseWrapper<bool>()
        {
            ResponseCode = ResponseCode.OK,
            Value = true
        };

    }
    public ResponseWrapper<bool> AreAnagramsUsingSequentialEqual(string userInput1, string userInput2)
    {
        _userInput1 = userInput1.OrderBy(x => x).ToList();
        _userInput2 = userInput2.OrderBy(x => x).ToList();

        if (_userInput1 is null || _userInput2 is null)
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.BadRequest
            };

        if (!_userInput1.SequenceEqual(_userInput2))
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.OK,
                Value = false
            };
        
        return new ResponseWrapper<bool>()
        {
            ResponseCode = ResponseCode.OK,
            Value = true
        };
    }
    public ResponseWrapper<bool> AreAnagramsNoArrays(string userInput1, string userInput2)
    {
        //1. Check for null
        if (userInput1 is null || userInput2 is null)
        {
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.BadRequest,
                Value = false
            };
        }

        if (userInput1.Length != userInput2.Length)
        {
            return new ResponseWrapper<bool>()
            {
                ResponseCode = ResponseCode.OK,
                Value = false
            };
        }

        userInput1 = new string(userInput1.OrderBy(x => x).ToArray());
        userInput2 = new string(userInput2.OrderBy(x => x).ToArray());

        //2. Replicate a manual sequential equal
        for (int i = 0; i < userInput1.Length; i++)
        {
            if (userInput1[i] != userInput2[i])
            {
                return new ResponseWrapper<bool>()
                {
                    ResponseCode = ResponseCode.OK,
                    Value = false
                };
            }
        }

        return new ResponseWrapper<bool>()
        {
            ResponseCode = ResponseCode.OK,
            Value = true
        };
    }
}