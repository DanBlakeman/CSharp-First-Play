using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			Console.WriteLine ("Welcome to Divisor.io\nEnter a number to be divided:");
			double firstInput = Convert.ToDouble ( Console.ReadLine () );
			Console.WriteLine ("and the number to divide it by:");
			double secondInput = Convert.ToDouble ( Console.ReadLine () );
			Console.WriteLine (firstInput + " divided by " + secondInput + " equals "  + firstInput / secondInput + "!");
			goto Start;
		}
	}
}
