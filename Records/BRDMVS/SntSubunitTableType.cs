using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class SntSubunitTableType : Record
	{
		public class SntSubunitTabType : Record
		{
			public IntField SntSubunitNum = new IntField(5);
		}
		public SntSubunitTabType[] SntSubunitTab = (from occurs in Enumerable.Range(1, 100) select new SntSubunitTabType()).ToArray();
	}
}
