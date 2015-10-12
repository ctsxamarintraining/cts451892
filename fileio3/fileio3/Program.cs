using System;
using System.IO;

namespace fileio3
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			using (FileStream stream = File.OpenRead("/Users/apple/Desktop/uthra/fileio3/fileio3/bin/Debug/read.txt"))
			using (FileStream writeStream = File.OpenWrite("/Users/apple/Desktop/uthra/fileio3/fileio3/bin/Debug/write.txt"))
			{
				//BinaryReader reader = new BinaryReader(stream);
				//BinaryWriter writer = new BinaryWriter(writeStream);

				// create a buffer to hold the bytes 
				byte[] buffer = new Byte[1000000];
				int bytesRead;

				// while the read method returns bytes
				// keep writing them to the output stream
				while ((bytesRead =
					stream.Read(buffer, 0, 1000000)) > 0)
				{
					writeStream.Write(buffer, 0, bytesRead);
				}
			}
	}
}
}