using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class MiscWsFieldsType : Record
	{
		public MiscWsFieldsType()
		{
			WsDb2EffDate.Redefine(WsDb2EffDatex);
		}
		public class WsDb2EffDatexType : Record
		{
			public StrField WsDb2EffCcyy = new StrField(4);
			public CharField Filler2 = new CharField('-');
			public StrField WsDb2EffMm = new StrField(2);
			public CharField Filler3 = new CharField('-');
			public StrField WsDb2EffDd = new StrField(2);
		}
		public WsDb2EffDatexType WsDb2EffDatex = new WsDb2EffDatexType();
		public StrField WsDb2EffDate = new StrField(10);
		public StrField StartDt = new StrField(10, "2000-06-30");
		public StrField LastEnteredDt = new StrField(10, char.MaxValue.ToString());
		public IntField Sub = new IntField(3, 0);
		public CharField HoldStackId = new CharField(' ');
		public IntField HoldCoId = new IntField(5, 0, true);
		/*
		      *    03  HOLD-FCLASS1                PIC S9(2) COMP-3.
		      *    03  HOLD-FCLASS2                PIC S9(2) COMP-3.
		      *    03  HOLD-FCLASS3                PIC S9(2) COMP-3.
		      *    03  HOLD-CURRENT-FCLASS         PIC S9(2) COMP-3 VALUE ZEROS.
		           */
		public DecimalField HoldCurrentInsplan = new DecimalField(5, 0, 0, true);
		public IntField HoldTemp1InsPlan = new IntField(5, 0);
		public IntField HoldTemp2InsPlan = new IntField(5, 0);
		public StrField HoldTemp3InsPlan = new StrField(6, new string('0', 6));
		public IntField HoldCompareIplan = new IntField(5, 0);
		public IntField HoldTotOutp1Found = new IntField(5);
		public DecimalField HoldTotChgs1 = new DecimalField(7, 2);
		public IntField AcctsWithChgs = new IntField(3, 0);
		public IntField AcctsWithoutChgs = new IntField(3, 0);
		public IntField AcctsThisSsn = new IntField(3, 0);
		public class HoldDb2DtType : Record
		{
			public IntField HoldDb2Cc = new IntField(2);
			public IntField HoldDb2Yy = new IntField(2);
			public CharField Filler4 = new CharField();
			public IntField HoldDb2Mm = new IntField(2);
			public CharField Filler5 = new CharField();
			public IntField HoldDb2Dd = new IntField(2);
		}
		public HoldDb2DtType HoldDb2Dt = new HoldDb2DtType();
		public LongField HoldSsno = new LongField(9);
		/*
		      *    03  HOLD-SSNO-RDF REDEFINES HOLD-SSNO.
		      *        05  HOLD-PART1-SSNO         PIC 999.
		      *        05  HOLD-PART2-SSNO         PIC 99.
		      *        05  HOLD-PART3-SSNO         PIC 9999.
		           */
		public StrField AdjustedAdmitDt = new StrField(10);
	}
}
