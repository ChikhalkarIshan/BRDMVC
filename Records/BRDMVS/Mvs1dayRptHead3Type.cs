using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Mvs1dayRptHead3Type : Record
	{
		public StrField Filler153 = new StrField(49);
		public StrField Med72hrSeqa = new StrField(36, "OVERLAPPING OUTPATIENT REGISTRATIONS");
		public StrField Filler154 = new StrField(48);
	}
}
