using System;

using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace fileio4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			byte i;
			string originData;
			string encryptedData;
			string valueFromFile;
			string decryptedData;

			//create key and initial vector
			byte[] key = new byte[24];
			byte[] vector = new byte[16];

			for (i = 0; i < 24; i++) key[i] = i;
			for (i = 0; i < 16; i++) vector[i] = i;

			//take data from the user
			Console.WriteLine("Enter the data to be encrypted");
			originData = Console.ReadLine();

			//encrypting the data given by user
			encryptedData = Encryption(originData, key, vector);


			//write to a file
			System.IO.File.WriteAllText(@"/Users/apple/Desktop/uthra/fileio4/Encryptedfile.txt", encryptedData);


			//Read the file
			valueFromFile = System.IO.File.ReadAllText(@"/Users/apple/Desktop/uthra/fileio4/Encryptedfile.txt");
			Console.WriteLine("Value from file: " + valueFromFile);


			//decrypting data retrieved from the file
			decryptedData = Decryption (valueFromFile, key, vector);
			Console.WriteLine("decrypted: " + decryptedData);


			Console.ReadKey();
		}


		public static string Encryption(string plainText, byte[] rgbKey, byte[] rgbIV)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			ICryptoTransform encryptor = null;

			byte[] encryptedBytes = null;
			byte[] textBytes = null;

			MemoryStream msEncrypt = null;
			CryptoStream csEncrypt = null;
			StringBuilder encryptedString = null;

			int i;

			//create byte array
			textBytes = new byte[plainText.Length];
			for (i = 0; i < plainText.Length; i++)
			{
				textBytes[i] = (byte)plainText[i];
			}

			//create encryptor
			encryptor = rijndaelManaged.CreateEncryptor(rgbKey, rgbIV);

			//encrypt
			msEncrypt = new MemoryStream();
			csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

			//write
			csEncrypt.Write(textBytes, 0, plainText.Length);
			csEncrypt.FlushFinalBlock();

			//get encrypted array of bytes.
			encryptedBytes = msEncrypt.ToArray();

			//create string
			encryptedString = new StringBuilder(encryptedBytes.Length);
			for (i = 0; i < encryptedBytes.Length; i++)
			{
				encryptedString.Append((char)(encryptedBytes[i]));
			}

			return encryptedString.ToString();
		}

		public static string Decryption(string encryptedText, byte[] rgbKey, byte[] rgbIV)
		{
			byte[] encryptedBytes = new byte[encryptedText.Length];
			byte[] decryptedBytes = null;

			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			ICryptoTransform decryptor = null;

			MemoryStream msDecrypt = null;
			CryptoStream csDecrypt = null;

			int i;

			StringBuilder builderDecryptedText;

			//create byte array
			for (i = 0; i < encryptedText.Length; i++)
			{
				encryptedBytes[i] = (byte)encryptedText[i];
			}

			//create decryptor
			decryptor = rijndaelManaged.CreateDecryptor(rgbKey, rgbIV);

			//decrypt
			msDecrypt = new MemoryStream(encryptedBytes);
			csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

			//read
			decryptedBytes = new byte[encryptedText.Length];
			csDecrypt.Read(decryptedBytes, 0, decryptedBytes.Length);

			//create string
			builderDecryptedText = new StringBuilder();
			for (i = 0; i < decryptedBytes.Length; i++)
			{
				if (0 != decryptedBytes[i]) //truncate '0' because array has always a size of x*16
				{
					builderDecryptedText.Append((char)(decryptedBytes[i]));
				}
			}

			return builderDecryptedText.ToString();
		}
	}
}

