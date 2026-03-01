namespace InterviewPractice.App.Models;
using InterviewPractice.App.Enums;

public class ResponseWrapper<T>
{
    public ResponseCode ResponseCode { get; set; }
    public T? Value { get; set; }
}

