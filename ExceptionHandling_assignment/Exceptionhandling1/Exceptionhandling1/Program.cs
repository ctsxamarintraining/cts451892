using System;

namespace Exceptionhandling1
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			int[] array=new int[5];
			int count = 0;
			while (count <=array.Length) 
			{
				try
				{
					Console.WriteLine ("Please add a number to array");
					int num = Convert.ToInt16 (Console.ReadLine ());
					array[count]=num;

					Console.WriteLine("numbers in the array");
					for (int j = 0; j <=count; j++) 
					{
						Console.Write ( array [j]+",");
					}
					Console.WriteLine();
					count++;
				}


				catch(IndexOutOfRangeException ie) {
					Console.WriteLine (ie.Message);
				}

				catch(FormatException fe){
					Console.WriteLine (fe.Message);
				}

				catch(Exception e){
					Console.WriteLine (e.Message);
				}
			}
		}
	}
}

