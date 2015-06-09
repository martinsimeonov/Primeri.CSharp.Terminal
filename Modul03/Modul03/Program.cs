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

			//Форматиране с дименсия
			string _format = "#0.00 м3";

			//Степенуване
			c = Math.Pow ( a, b );
			Console.WriteLine ("\n\n>a ^ b = " + c.ToString ( _format ));

			//Kоренуване
			c = Math.Sqrt ( b );
			Console.WriteLine ("\n\n>b ^ 1/2 = " + c.ToString ( _format ));

			//Закръгления
			c = Math.Round ( a / b ) ;
			Console.WriteLine ("\n\n>(a / b) = " + c.ToString () );
		}
	}
}
