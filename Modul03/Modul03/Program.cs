using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = 0, b = 0, c = 0;

			Console.Write ("> a = ");
			a = Convert.ToDouble (Console.ReadLine ());
			Console.Write ("> b = ");
			b = Convert.ToDouble (Console.ReadLine ());

			string _format = "#0.00 м3";


			Console.WriteLine ("\n\n>a / b = " + (a / b).ToString ( _format ));
		}
	}
}
