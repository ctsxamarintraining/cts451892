using System;

namespace partialclass
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			student stu = new student ();
			stu.getDetails ("xxx", 1, "chennai");
			stu.printDetails ();
		}
	}
}
