using System;

namespace ExtensionMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the String");
			string str = Console.ReadLine ();
			Console.WriteLine ("No of characters in the given String{0}", str.getnoofchars ());
			Console.WriteLine ("No of words in the given string{0}", str.getnoofwords ());
		}
	}
}
