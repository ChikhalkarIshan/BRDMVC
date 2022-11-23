using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Mvs1dayRptHead2Type : Record
	{
		public CharField Filler148 = new CharField(' ');
		public StrField Med72hrHead2 = new StrField(132);
	}
}
