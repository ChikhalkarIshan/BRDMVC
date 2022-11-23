using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Csr1SsnoTableType : Record
	{
		public class SsnoEntryTblType : Record
		{
			public LongField SsnoEntry = new LongField(9);
			public StrField SsnoAdmitDt = new StrField(10);
		}
		public SsnoEntryTblType[] SsnoEntryTbl = (from occurs in Enumerable.Range(1, 50000) select new SsnoEntryTblType()).ToArray();
	}
}
