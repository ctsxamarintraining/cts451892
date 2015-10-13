using System;
using System.Collections.Generic;
using System.Linq;

namespace anonymousTypes
{
	class MainClass
	{
		class data{
			public string name;
			public int id;
			public string city;
		}
		public static void Main (string[] args)
		{
			List<data> details = new List<data>
			{
				new data {name="abc", id=1,city="xyz"},
				new data {name="def", id=2,city="pqr"},
				new data {name="ghi", id=3,city="stv"},
				new data {name="jkl", id=4,city="mno"},

			};
			var anonymousData = from pl in details
				select new { pl.name, pl.id, pl.city };
			foreach (var m in anonymousData)
			{
				Console.WriteLine("Name : " + m.name + "  id:" + m.id + "  city:"+m.city);
			}

		}

	}
}
