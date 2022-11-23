using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class DashLineType : Record
	{
		public CharField Filler230 = new CharField();
		public StrField Filler231 = new StrField(132, new string('-', 132));
	}
}
