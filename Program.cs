using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int firstInput = Convert.ToInt32 ( Console.ReadLine () );
			int secondInput = Convert.ToInt32 ( Console.ReadLine () );
			Console.WriteLine (firstInput * secondInput);
		}
	}
}
