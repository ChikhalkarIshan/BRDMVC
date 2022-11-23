using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class MgdCareDaysTableType : Record
	{
		public class MgdCareDaysTabType : Record
		{
			public DecimalField InsurancePlan = new DecimalField(5, 0, true);
			public StrField PayorName = new StrField(25);
		}
		public MgdCareDaysTabType[] MgdCareDaysTab = (from occurs in Enumerable.Range(1, 1) select new MgdCareDaysTabType()).ToArray();
	}
}
