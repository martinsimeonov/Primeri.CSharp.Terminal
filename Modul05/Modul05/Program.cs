using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string usercommand = "";
			
			//Потребелски команди
			do
			{
				Console.Write ("$ ");	usercommand = Console.ReadLine ();

				if ( usercommand.Contains ( "cmd01" ) )	cmd01	( usercommand );
				if ( usercommand.Contains ( "cmd02" ) )	Console.WriteLine (	cmd02 ( usercommand ) );

			}while ( usercommand != "exit" );

		}


		public static void cmd01 ( string _input )	//cmd01 5 			---> 5^2 = 25
		{
			try
			{
				double _temp = 0;

				if ( double.TryParse ( _input.Split(' ')[1], out _temp ) )
				{
					Console.WriteLine ("\nРезултат от " + _temp.ToString () + "^2: " + (_temp * _temp).ToString() );
				}


			}catch{
			}
		}

		public static int cmd02 ( string _input )	//cmd02 5		--> 5*5*5 = 125
		{
			int _temp = 0;

			if ( int.TryParse ( _input.Split(' ')[1], out _temp ) )
			{
				_temp = _temp * _temp * _temp;
			}

			return _temp;
		}



	}
}
