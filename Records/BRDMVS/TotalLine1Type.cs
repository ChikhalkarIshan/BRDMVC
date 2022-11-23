using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class TotalLine1Type : Record
	{
		public StrField Filler232 = new StrField(5);
		public StrField Filler233 = new StrField(33, "TOTAL ACCOUNTS                 : ");
		public IntField TotPatCount1 = new IntField(5);
		public StrField Filler234 = new StrField(89);
	}
}
