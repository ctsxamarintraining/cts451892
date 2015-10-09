using System;
using System.IO;
namespace reverseafile
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = "A class is the most powerful data type in C#. Like a structure, " +
				"a class defines the data and behavior of the data type. ";
			System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
			using (FileStream stream = File.OpenRead("C:\\Users\\Public\\TestFolder\\WriteText.txt"))
			using (FileStream writeStream = File.OpenWrite("D:\\file2.txt"))
			{
				BinaryReader reader = new BinaryReader(stream);

				reader.BaseStream.Seek(1024,SeekOrigin.End);

				//intialize array of size 1024
				char [] arr = new char[1024];
				//loop now and read backwards
				While((reader.BaseStream.Position){

					arr.Initialize();
					//Move back 1024 bytes (for better control)
					reader.BaseStream.Seek(1024,SeekOrigin.Current);
					//read 1024 bytes.
					int bytesRead = reader.Read(arr,0,1024);

				}
				BinaryWriter writer = new BinaryWriter(writeStream);


				// create a buffer to hold the bytes 
				byte[] buffer = new Byte[1024];


				// while the read method returns bytes
				// keep writing them to the output stream
				while (bytesRead)
				{
					writeStream.Write(buffer, 0, bytesRead);
				}
			}
		}
	}
}
