using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class DetlLine1Type : Record
	{
		public StrField Filler203 = new StrField(2);
		public StrField DetlPatName = new StrField(24);
		public CharField Filler204 = new CharField(' ');
		public StrField DetlEnterDt = new StrField(8);
		public StrField Filler205 = new StrField(2);
		public CharField DetlHoldInd = new CharField();
		public StrField Filler206 = new StrField(9);
		public StrField DetlUserid = new StrField(10);
		public StrField Filler207 = new StrField(4);
		public StrField DetlHoldRsn = new StrField(50);
		/*
		      *    05  FILLER               PIC X(98) VALUE SPACES.
		           */
		public StrField Filler208 = new StrField(22);
	}
}
