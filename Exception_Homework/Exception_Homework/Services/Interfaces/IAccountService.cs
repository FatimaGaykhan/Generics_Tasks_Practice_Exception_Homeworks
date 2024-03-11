using System;
namespace Exception_Homework.Services.Interfaces
{
	public interface IAccountService
	{
		bool SignIn(string email, string password);
		
	}
}

