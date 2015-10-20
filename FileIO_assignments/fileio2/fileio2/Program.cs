using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileio2
{
	class Program
	{
		static void Main(string[] args)
		{

		
			string folderName = @"/Users/apple/Desktop/uthra/fileio2/Source Folder";

			string pathString1 = System.IO.Path.Combine(folderName, "SubFolder1");
			string pathString2 = System.IO.Path.Combine(folderName, "SubFolder2");

			string pathString3 = System.IO.Path.Combine(pathString1, "SubSubFolder1");
			string pathString4 = System.IO.Path.Combine(pathString2, "SubSubFolder2");

			System.IO.Directory.CreateDirectory(pathString1);
			System.IO.Directory.CreateDirectory(pathString2);

			System.IO.Directory.CreateDirectory(pathString3);
			System.IO.Directory.CreateDirectory(pathString4);

			File.WriteAllText(Path.Combine(pathString1, "fileOne.txt"), "hai");
			File.WriteAllText(Path.Combine(pathString2, "filetwo.txt"), "hello");
			File.WriteAllText(Path.Combine(folderName, "file.txt"), "how");
			File.WriteAllText(Path.Combine(pathString3, "fileThree.txt"), "are");
			File.WriteAllText(Path.Combine(pathString4, "fileFour.txt"), "you");

			if (System.IO.File.Exists(folderName))            
			{
				Console.WriteLine("File \"{0}\" already exists.", folderName);
				return;
			}

			System.Console.WriteLine("File Creation Completed");

			CopyFolder(@"/Users/apple/Desktop/uthra/fileio2/Source Folder",
				@"/Users/apple/Desktop/uthra/fileio2/Destination Folder");

			System.Console.WriteLine("Copying Files & Folders Completed");
			System.Console.ReadLine();

		}

		static public void CopyFolder(string sourceFolder, string destFolder)
		{
			if (!Directory.Exists(destFolder))
				Directory.CreateDirectory(destFolder);

			string[] files = Directory.GetFiles(sourceFolder);
			foreach (string file in files)
			{
				string name = Path.GetFileName(file);
				string dest = Path.Combine(destFolder, name);
				File.Copy(file, dest);
			}
			string[] folders = Directory.GetDirectories(sourceFolder);
			foreach (string folder in folders)
			{
				string name = Path.GetFileName(folder);
				string dest = Path.Combine(destFolder, name);
				CopyFolder(folder, dest);
			}

		}

	}
}
