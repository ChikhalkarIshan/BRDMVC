using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class StoredCsr2LinesType : Record
	{
		public class StoredCsr2LineType : Record
		{
			public StrField StSubUnit = new StrField(5);
			public LongField StPatNo = new LongField(12);
			public StrField StAdmitDt = new StrField(10);
			public StrField StDischDt = new StrField(10);
			public DecimalField StIplan = new DecimalField(5, 0, true);
			public IntField StFc = new IntField(2);
			public StrField StType = new StrField(3);
			public StrField StSvcCode = new StrField(4);
			public DecimalField StChgs = new DecimalField(11, 2, true);
			public StrField StFbillDt = new StrField(10);
			public StrField StDiag = new StrField(11);
			public StrField StDiagDisc = new StrField(24);
			public StrField StDiag_0 = new StrField(11);
			public StrField StDiagDisc_0 = new StrField(24);
		}
		public StoredCsr2LineType[] StoredCsr2Line = (from occurs in Enumerable.Range(1, 1001) select new StoredCsr2LineType()).ToArray();
		public class Csr2LineInitType : Record
		{
			public StrField Filler6 = new StrField(5);
			public LongField Filler7 = new LongField(12, 0);
			public StrField Filler8 = new StrField(10);
			public StrField Filler9 = new StrField(10);
			public DecimalField Filler10 = new DecimalField(5, 0, 0, true);
			public IntField Filler11 = new IntField(2, 0);
			public StrField Filler12 = new StrField(3);
			public StrField Filler13 = new StrField(4);
			public DecimalField Filler14 = new DecimalField(11, 2, 0, true);
			public StrField Filler15 = new StrField(10);
			public StrField Filler16 = new StrField(11);
			public StrField Filler17 = new StrField(24);
			public StrField Filler18 = new StrField(11);
			public StrField Filler19 = new StrField(24);
		}
		public Csr2LineInitType Csr2LineInit = new Csr2LineInitType();
	}
}
