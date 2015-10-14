using System;

namespace exceptionhandling2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
				Console.WriteLine("Enter a number: ");
				int number = Convert.ToInt32 (Console.ReadLine ());

				if(number < 0)
				{
					throw new NegativeNumberException();
				}
				else{
					Console.WriteLine("The square root of given number is: " + Math.Sqrt(number));
				}
			}


			catch(FormatException e){
				Console.WriteLine ("Invalid number");
			}

			catch(NegativeNumberException e){
				Console.WriteLine ("Invalid number");
			}

			catch(Exception e){
				Console.WriteLine ("Invalid number");
			}
			finally
			{
				Console.WriteLine ("Goodbye");
			}
		  }
	  }
	class NegativeNumberException : Exception
	{
	}
}

