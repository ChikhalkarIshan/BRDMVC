using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class HoldAccOutp1FieldsType : Record
	{
		public LongField HoldPatNo = new LongField(12, true);
		public StrField HoldPatName = new StrField(24);
		public StrField HoldPatType = new StrField(3);
		public StrField HoldEnteredDt = new StrField(10);
		public StrField HoldAdmitDt = new StrField(10);
		public StrField HoldDischDt = new StrField(10);
		public StrField HoldFbillDt = new StrField(10);
		public IntField HoldFinClass = new IntField(2, true);
		public DecimalField HoldInsPlan = new DecimalField(5, 0, true);
		public StrField HoldSvcCode = new StrField(4);
		public LongField HoldPatSsno = new LongField(9, true);
		public StrField HoldSubUnit = new StrField(5);
		public DecimalField HoldAncChg = new DecimalField(9, 2, true);
		public DecimalField HoldDailyCareChg = new DecimalField(9, 2, true);
		/*
		      *    03  HOLD-PAT-AGE                PIC X(4).
		      *    03  HOLD-BIRTH-DT               PIC X(10).
		           */
		public StrField HoldBirthDt = new StrField(10, "0001-01-01");
		public StrField HoldPayorName = new StrField(25);
		public DecimalField HoldInsurancePlan = new DecimalField(5, 0, true);
	}
}
