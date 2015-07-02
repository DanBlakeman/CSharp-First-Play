using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int firstNum = 7;
			int secondNum = 8;

			Console.WriteLine ("What is " + firstNum + " * " + secondNum + "?" );
			int userResponse = Convert.ToInt32 (Console.ReadLine ());
			if (userResponse == 56) {
				Console.WriteLine ("Wahey, you win!");
			} else {
				Console.WriteLine ("Sorry, you lose.");
			}
		}
	}
}
