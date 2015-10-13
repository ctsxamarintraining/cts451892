using System;

namespace ExtensionMethod
{
	public static class stringExtension
	{
		public static int getnoofwords(this string str){
			int wrdCount = str.Split(' ' ).Length;
			return wrdCount; 
		}
		public static int getnoofchars(this string str){
			string withoutSpaces = str.Replace(" ","");
			int charCount = withoutSpaces.ToCharArray().Length;
			return charCount;
		}
	}
}

