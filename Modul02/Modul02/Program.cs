using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;

			sum = a + b;

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на ++");
			a++;
			Console.WriteLine ( a );

			a = 15; b = 10;

			Console.WriteLine ("\nСтандартно делене");
			Console.WriteLine ( a / b);		//1

			Console.WriteLine ("\nХващане на остатък");
			Console.WriteLine ( a % b );	//5, 1.5
		}
	}
}
