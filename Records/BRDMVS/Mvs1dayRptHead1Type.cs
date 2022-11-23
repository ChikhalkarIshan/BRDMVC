using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Mvs1dayRptHead1Type : Record
	{
		public CharField Filler147 = new CharField(' ');
		public StrField Med72hrHead1 = new StrField(127);
		public IntField Med72hrPgNo = new IntField(5, 0);
	}
}
