using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string _userinput = "";
			List<int> _list = new List<int> ();

			_list.Add (5);
			_list.Add (3);
			_list.Add (9);

			//Потребителски вход
			do {
				Console.Write ("? ");
				_userinput = Console.ReadLine ();


				//Добавяне на стойности
				//add <int>
				if ( _userinput.ToLower().Contains ("add"))
				{
					try
					{
						int _add = 0;

						if ( int.TryParse ( _userinput.Split (' ')[1], out _add ) )
						{
							_list.Add ( _add );
						}

						Console.WriteLine ();
					}catch{}
				}

				//Преглед на List
				if ( _userinput.ToLower().Contains ("show") )
				{
					Console.Write ( "Списък: " );

					foreach (int value in _list)
					{
						Console.Write ( value.ToString () + ", ");
					}

					Console.WriteLine ("\n");
				}

				//Размер на List
				if ( _userinput.ToLower().Contains ( "size" ) )
				{
					Console.WriteLine ("размер на списъка: " + _list.Count.ToString () + "\n");

				}


			} while(_userinput != "exit");

		}
	}
}
