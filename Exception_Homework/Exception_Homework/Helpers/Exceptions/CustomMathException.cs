using System;
namespace Exception_Homework.Helpers.Exceptions
{
	public class CustomMathException:Exception
	{
		public CustomMathException(string text):base(text)
		{
		}
	}
}

