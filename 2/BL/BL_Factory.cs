using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
	public class BL_Factory
	{
		private BL_Factory() { }
		private static IBL_imp instance = null;
		public static IBL_imp GetInstance()
		{
			if (instance == null)
				instance = new IBL_imp();
			return instance;
		}
	}
}
