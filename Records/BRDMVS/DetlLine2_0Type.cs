using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class DetlLine2_0Type : Record
	{
		public StrField Filler223 = new StrField(86);
		public StrField DetlPrinDiag_0 = new StrField(7);
		public CharField Filler224 = new CharField();
		public CharField DetlIcdVer_0 = new CharField();
		public StrField Filler225 = new StrField(3);
		public StrField DetlPrinDiagD_0 = new StrField(24);
		public CharField Filler226 = new CharField();
		public StrField DetlComments_0 = new StrField(15);
	}
}
