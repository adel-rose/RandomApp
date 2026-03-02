// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using InterviewPractice.App;
using InterviewPractice.App.Contracts;
using InterviewPractice.App.Enums;
using InterviewPractice.App.Models;
using InterviewPractice.App.Repositories;
using InterviewPractice.App.Services;
using InterviewPractice.App.Services.OOPServices;


#region encapsulation
//*******************************************************Encapsulation************************************************//
// var currentUser = new User()
// {
//     FirstName = "John",
//     LastName = "Doe",
//     AccountType = BankAccountType.Savings,
//     SessionValid = false
// };
//
// var _bank = new Bank();
//
// _bank.HeartBeat(currentUser.SessionValid);
//
// var response = _bank.Balance;
//
// if (response.ResponseCode == ResponseCode.OK)
// {
//     Console.WriteLine($"Access granted, balance = {response.Value}");
// }
//
// if (response.ResponseCode == ResponseCode.Denied)
// {
//     Console.WriteLine($"Access denied");
// }

//*******************************************************Encapsulation************************************************//
#endregion

#region abstraction

//*******************************************************Abstraction**************************************************//


//  var inMemoryDataSet = new List<User>()
//  {
//      new User()
//      {
//          FirstName = "John",
//          LastName = "Doe",
//          AccountType = BankAccountType.Savings
//      },
//      new User()
//      {
//          FirstName = "Jane",
//          LastName = "Doe",
//          AccountType = BankAccountType.Current
//      }
//  };
//  
// var usersWithCurrentAccounts = inMemoryDataSet.Where(user => user.AccountType == BankAccountType.Current);


//Refactored version
// var _userRepository = new UserRepository();
//
// var users = _userRepository.GetUsers();
//
// var usersWithCurrentAccounts = users.ResponseCode == ResponseCode.OK
//     ? users.Value.Where(user => user.AccountType == BankAccountType.Current) 
//     : new List<User>();
//
//
// foreach (var user in usersWithCurrentAccounts)
// {
//     Console.WriteLine($"First name: {user.FirstName}");
// }


//*******************************************************Abstraction**************************************************//
#endregion

#region polymorhpism

//*******************************************************Polymorphism*************************************************//
// Individual user loging in

//var userType = UserType.Individual;

 // var service = userType switch
 // {
 //     UserType.Corporate => (ILogginService)new CorporateLoginService(),
 //     UserType.Individual => new IndividualLoginService(),
 //     _ => throw new NotImplementedException()
 // };
    
 // var _loginService = new List<ILogginService>() { new CorporateLoginService(), new IndividualLoginService() };
 //
 // var service = _loginService.Where(service => service.Type == userType).FirstOrDefault();
 //
 // if (service is null)
 //     Console.WriteLine(false);
 //
 // service.Login();

//*******************************************************Polymorphism*************************************************//

#endregion

#region inheritance

//*******************************************************Inheritance & Polymorphism***********************************//

// var _paymentServices = new List<IPaymentService>() { new HostedPaymentPageService(), new ScanToPayService() };
//
// var _userRepository = new UserRepository();
//
// var user = _userRepository.GetUsers().Value.Where(user => user.SessionValid).FirstOrDefault();
//
// var userPaymentService = _paymentServices.Where(service => service.PaymentMethod == user.PaymentMethod).FirstOrDefault();
//
// var paymentInitiateResponse = userPaymentService.InitiatePayment(user);
//
// if(paymentInitiateResponse.ResponseCode == ResponseCode.OK)
//     Console.WriteLine($"Payment initiated: {paymentInitiateResponse.Value}");
//
// if(paymentInitiateResponse.ResponseCode == ResponseCode.Denied)
//     Console.WriteLine("Access denied");

//*******************************************************Inheritance & Polymorphism***********************************//

#endregion

var _service = new RandomService();

var response = _service.GetFirstNonRepeatingChar("aaaaabbbbbccccde");

Console.Write(response);


