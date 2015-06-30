using System;

namespace Fact
{
	class MainClass
	{
		// 5! = 5 * 4 * 3 * 2 * 1; 0! = 1

		public static int Fact ( int _fact )
		{
			if (_fact <= 1)
				return 1;
			else
				return _fact * Fact (_fact - 1);

				//2!	2	*	1

				//3!	3 * 2 * 1

		}

		public static void Main (string[] args)
		{
			Console.WriteLine ( Fact ( 3 ) );
			Console.WriteLine ( Fact ( 4 ) );
			Console.WriteLine ( Fact ( 5 ) );
			Console.WriteLine ( Fact ( 6 ) );
			Console.WriteLine ( Fact ( 7 ) );
			Console.WriteLine ( Fact ( 8 ) );
			Console.WriteLine ( Fact ( 9 ) );
		}
	}
}
