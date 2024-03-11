 using System;
using Exception_Homework.Models;

namespace Exception_Homework.Services.Interfaces
{
	public interface IUserService
	{
		User[] GetAll();
		User GetById(int id);
		void Delete(int id);
		
	}
}

