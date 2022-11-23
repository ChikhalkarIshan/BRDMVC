using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class DetlLine2Type : Record
	{
		public StrField Filler209 = new StrField(2);
		public StrField DetlSubUnit = new StrField(5);
		public StrField Filler210 = new StrField(2);
		public LongField DetlPatNum = new LongField(11);
		public StrField Filler211 = new StrField(6);
		public StrField DetlAdmitDt = new StrField(8);
		public StrField Filler212 = new StrField(2);
		public StrField DetlDischDt = new StrField(8);
		public StrField Filler213 = new StrField(2);
		public StrField DetlInsPlan = new StrField(6, new string('0', 6));
		public CharField Filler214 = new CharField(' ');
		public IntField DetlFinClass = new IntField(2);
		public CharField Filler215 = new CharField();
		public StrField DetlPatType = new StrField(3);
		public CharField Filler216 = new CharField();
		public StrField DetlSvcCode = new StrField(4);
		public CharField Filler217 = new CharField(' ');
		public DecimalField DetlTotChgs = new DecimalField(6, 2);
		public CharField Filler218 = new CharField();
		public StrField DetlFbillDt = new StrField(8);
		public CharField Filler219 = new CharField();
		public StrField DetlPrinDiag = new StrField(7);
		public CharField Filler220 = new CharField(' ');
		public CharField DetlIcdVer = new CharField();
		public StrField Filler221 = new StrField(3);
		public StrField DetlPrinDiagDesc = new StrField(24);
		public CharField Filler222 = new CharField(' ');
		public StrField DetlComments = new StrField(15);
	}
}
