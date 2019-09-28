using System;

namespace BankApp
{
    class Program
    {
         
        static void Main(string[] args)//Main is the entry
        {
            //Instance of an object ==object
            //...properties of object
            var account = new Account
            {
                EmailAddress = "test@test.com",
                AccountType = "Checking"

            };

            account.Deposit(2034.56M);

            Console.WriteLine($"AN:{account.AccountNumber}, " +
                $"Balance: {account.Balance:C}, " +
                $"AT:{account.AccountType}, " +
                $"EA: {account.EmailAddress}, " +
                $"CD:{account.CreatedDate}");
        
        }

    }
}
