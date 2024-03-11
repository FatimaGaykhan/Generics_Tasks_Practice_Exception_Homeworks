using System;
namespace Generic_Practise.Exceptions
{
	public class NotFoundException:Exception
	{
		public NotFoundException(string msj) : base(msj) { }
	}
}

