using System;

namespace garbagecollection2
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			int[] values = new int[50000];

				values = null;

			Console.WriteLine("Memory used before collection:       {0}", 
				GC.GetTotalMemory(true));
			GC.Collect ();

			Console.WriteLine("Memory used after collection:       {0}", 
				GC.GetTotalMemory(true));

			
		}
	}
}
