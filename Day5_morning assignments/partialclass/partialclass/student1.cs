using System;

namespace partialclass
{
	public partial class student
	{
		public string sName;
		public int sId;
		public string sDept;

		public void getDetails(string name,int id,string dept){
			
			sName = name;
			sId = id;
			sDept = dept;

		}
	}
}

