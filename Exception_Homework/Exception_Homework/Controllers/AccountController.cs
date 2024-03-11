using System;
using Exception_Homework.Helpers.Exceptions;
using Exception_Homework.Services;
using Exception_Homework.Services.Interfaces;

namespace Exception_Homework.Controllers
{
	public class AccountController
	{
		private readonly IAccountService _accountService;

		public AccountController()
		{
			_accountService = new AccountService();
		}
		public void SignIn()
		{
			string email = "fatima@code.edu.az";
			string password = "Fatima5123";
			try
			{
				if (!email.Contains('@'))
				{
					throw new InvalidEmailException("Email format is wrong");
				}
				bool response = _accountService.SignIn(email, password);
				if (response)
                    Console.WriteLine(" Sign in success");
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			} 
		}
	}
}

