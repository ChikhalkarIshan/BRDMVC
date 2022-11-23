using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Mvs1dayRptHead3aType : Record
	{
		public StrField Filler149 = new StrField(2);
		public StrField Filler150 = new StrField(6, "***** ");
		public StrField Med72hrIplan = new StrField(6);
		public CharField Filler151 = new CharField();
		public StrField Med72hrPayorName = new StrField(25);
		public StrField Filler152 = new StrField(90);
	}
}
