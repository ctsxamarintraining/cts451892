using System;
using System.IO;

namespace exceptionhandling3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the Path");
			string spath = Console.ReadLine ();
			try{
			string resulttext = System.IO.File.ReadAllText (spath);
			}


			/*path is null*/
			catch(ArgumentNullException ane){
				Console.WriteLine (ane.Message);

			}
			/*path is a zero-length string, contains only white space, or contains one or more invalid characters throw exception*/
			catch(ArgumentException ae){
				Console.WriteLine (ae.Message);
			}



			/*The file specified in path was not found.*/
			catch(FileNotFoundException fn){
				Console.WriteLine (fn.Message);
			}

			/*path is in an invalid format.*/
			catch(NotSupportedException ns){
				Console.WriteLine (ns.Message);
			}
	
		}
	}
}
