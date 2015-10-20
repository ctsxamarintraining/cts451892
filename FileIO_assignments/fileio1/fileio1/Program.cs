using System;
using System.IO;
using System.Collections;
namespace fileio1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			File.Create ("outputFile.text");

			StreamReader objReader = new StreamReader("test.text");
			string sLine = "";
			ArrayList arrText = new ArrayList();

			while (sLine != null)
			{
				sLine = objReader.ReadLine();
				if (sLine != null)
					arrText.Add(sLine);
			}
			objReader.Close();


			arrText.Reverse();

			foreach (string sOutput in arrText) {

				File.AppendAllText ("/Users/apple/Desktop/uthra/fileio1/fileio1/bin/Debug/outputFile.txt", sOutput);
				File.AppendAllText ("/Users/apple/Desktop/uthra/fileio1/fileio1/bin/Debug/outputFile.txt", "\n");
			}

		}
	}
}
