using System;
namespace Exception_Homework.Helpers.Exceptions
{
	public class InvalidEmailException:Exception
	{
		public InvalidEmailException(string msj) : base(msj) { }
	}
}

