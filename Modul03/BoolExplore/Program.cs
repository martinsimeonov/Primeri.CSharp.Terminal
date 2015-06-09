using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//bool _b = true;		// true / false

			//bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2};

			int _ui = Convert.ToInt32 ( Console.ReadLine () );

			bool _check01 = _ui <= _i.Length;
			bool _check02 = _ui > 0;

			Console.WriteLine ( _check01 );
			Console.WriteLine ( _check02 );
			Console.WriteLine ( _i [ _ui - 1] );
		}
	}
}
