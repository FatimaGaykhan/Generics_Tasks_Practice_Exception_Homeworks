using System;
using Exception_Homework.Helpers.Exceptions;
using Exception_Homework.Models;
using Exception_Homework.Services.Interfaces;

namespace Exception_Homework.Services
{
	public class AccountService:IAccountService
	{
        private readonly IUserService _userService;
		public AccountService()
		{
            _userService = new UserService();
		}

        public bool SignIn(string email, string password)
        {
            User[] users = _userService.GetAll();
            User existUser = users.FirstOrDefault(m => m.Email == email && m.Password == password);
            return existUser == null ? throw new UserNotFoundException("User not found") : true;
        }
    }
}

