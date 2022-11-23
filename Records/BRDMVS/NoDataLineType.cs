using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class NoDataLineType : Record
	{
		public StrField Filler227 = new StrField(50);
		public StrField Filler228 = new StrField(34, "* * *  NO  DATA  TO  REPORT  * * *");
		public StrField Filler229 = new StrField(49);
	}
}
