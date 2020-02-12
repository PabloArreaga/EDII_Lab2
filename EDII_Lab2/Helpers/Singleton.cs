using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDII_Lab2.Models;

namespace EDII_Lab2.Helpers
{
	public class Singleton
	{
		private static Singleton _instance = null;
		public static Singleton Instance
		{
			get
			{
				if (_instance == null) _instance = new Singleton();
				{
					return _instance;
				}
			}
		}
		public List<Soda> sodaList = new List<Soda>();
	}
}
