using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] _table = { "Иван", "Гошо", "Гергана"};

			//Антетка на таблица
			Console.WriteLine ("Име");
			Console.WriteLine ("============");

			//Тяло на таблица
			for (int i = 0; i < _table.Length; i++ )
			{
				//Код на цикъла
				Console.WriteLine ( _table [i] );
			}  
		}
	}
}
