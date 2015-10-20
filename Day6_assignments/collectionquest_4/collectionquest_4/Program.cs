using System;
using System.Collections.Generic;

namespace collectionquest_4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* List Operations */

			List<int> list = new List<int>();

			list.Add (1);
			list.Add (2);
			list.Add (3);


			list.Remove (1);

			list.Insert (0, 20);

			Console.WriteLine ("before clearing the list {0}",list.Count);
			list.Clear ();

			Console.WriteLine ("afetr clearing the list {0}",list.Count);

			/* Dictionary Operations */

			Dictionary<int, string> dictionary = new Dictionary<int, string> ();

			dictionary.Add (1, "xxx");
			dictionary.Add (2, "yyy");

			dictionary.ContainsValue ("yyy");
			dictionary.Remove (2);

			dictionary.Add (3, "zzz");
			Console.WriteLine ("before clearing the dictionary {0}",dictionary.Count);
			dictionary.Clear ();
			Console.WriteLine ("after clearing the dictionary {0}",dictionary.Count);
		}
	}
}
