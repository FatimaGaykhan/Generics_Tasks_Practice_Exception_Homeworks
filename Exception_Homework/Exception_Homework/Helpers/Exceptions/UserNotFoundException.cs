using System;
namespace Exception_Homework.Helpers.Exceptions
{
	public class UserNotFoundException:Exception
	{
		public UserNotFoundException(string msj) : base(msj) { }
		
	}
}

