using System;
using Exception_Homework.Helpers.Exceptions;
using Exception_Homework.Helpers.Extensions;

namespace Exception_Homework.Controllers
{
	public class CalculationController
	{
		public void GetFactorial()
		{
			try
			{

                int number = -5;
                Console.WriteLine(number.FactorialOfNumber());
            }
			catch (CustomMathException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

