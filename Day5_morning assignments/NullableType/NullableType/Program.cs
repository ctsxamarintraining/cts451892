using System;

namespace NullableType
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int? num = null;
			Console.WriteLine (num.GetValueOrDefault());
			num = 10;
			Console.WriteLine (num.Value);
		}
	}
}
