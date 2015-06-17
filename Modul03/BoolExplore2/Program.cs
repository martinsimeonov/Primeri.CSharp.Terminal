using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4, 3, 2};

			int _ui = 0;
			string _input = "0";

			Console.Write ("Моля въведете индекс: ");
			_input = Console.ReadLine ();

			bool _check01 = int.TryParse ( _input, out _ui );

			_ui = ( _ui <= _i.Length ) ? _ui : 3;
			_ui = (_ui > 0) ? _ui : 1;


			if (_check01) {
				Console.WriteLine (_i [_ui - 1]);
			}
		}
	}
}
