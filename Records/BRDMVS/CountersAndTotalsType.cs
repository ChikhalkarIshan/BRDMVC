using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class CountersAndTotalsType : Record
	{
		public IntField LineCtr = new IntField(2, 60);
		public IntField PageCount = new IntField(3, 0);
		public IntField WsTotPatCnt = new IntField(5, 0);
		public IntField BrbcssCount = new IntField(5, 0, true);
		public IntField TotCombined = new IntField(5, 0);
		public IntField InsPlanCtr = new IntField(4, 0, true);
	}
}
