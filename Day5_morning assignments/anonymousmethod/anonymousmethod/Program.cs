using System;

namespace anonymousmethod
{
	class MainClass
	{
		delegate void getString(string s);
		public static void Main (string[] args)
		{
			// Instantiate the delegate type using an anonymous method.
			getString str = delegate(string j)
			{
				System.Console.WriteLine(j);
			};

			// Results from the anonymous delegate call.
			str("The delegate using the anonymous method is called.");
		}
	}
}
