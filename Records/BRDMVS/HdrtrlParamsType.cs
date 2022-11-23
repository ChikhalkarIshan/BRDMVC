using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class HdrtrlParamsType : Record
	{
		public StrField PlOutputDdname = new StrField(8);
		public CharField PlHudhtbType = new CharField();//88  PlHdrType         VALUE 'H'CharField.
		//88  PlCtlType         VALUE 'C'CharField.
		//88  PlTlrType         VALUE 'T'CharField.
		public class PlApplrptCodeType : Record
		{
			public StrField PlApplCode = new StrField(4);
			public StrField PlRptCode = new StrField(6);
		}
		public PlApplrptCodeType PlApplrptCode = new PlApplrptCodeType();
		public StrField PlOutputUnit = new StrField(4);
		public CharField PlDataType = new CharField();
		public StrField PlDestApplic = new StrField(2);
		public class PlReportDateType : Record
		{
			public IntField PlRptMm = new IntField(2);
			public IntField PlRptDd = new IntField(2);
			public IntField PlRptYy = new IntField(4);
		}
		public PlReportDateType PlReportDate = new PlReportDateType();
		public IntField PlRetdStatus = new IntField(3);
		/*
		      *VALUE OF BLANK FOR THE PL-REQ-HEADER-SW IS INVALID.  YOU MUST
		      * ENTER A VALUE OF Y OR N.
		           */
		public CharField PlReqHeaderSw = new CharField();//88  DoNotPrintHeader        VALUE 'N'CharField.
		//88  PrintHeader               VALUE 'Y'CharField.
		//88  ForcePrintHeader         VALUE 'F'CharField.
		public IntField SecLvl = new IntField(2);
		public CharField ReFreq = new CharField();//88  DailyReport               VALUE 'D'CharField.
		//88  WeeklyReport              VALUE 'W'CharField.
		//88  PreliminaryReport         VALUE 'P'CharField.
		public CharField Filler235 = new CharField();
		public IntField RePriority = new IntField(1);//88  Priority_1                 VALUE 1IntField.
		//88  Priority_2                 VALUE 2IntField.
		//88  Priority_3                 VALUE 3IntField.
		//88  DoNotSendNotRequested  VALUE 4IntField.
		public CharField ReRptReq = new CharField();//88  ReportWasRequested       VALUE 'Y'CharField.
		//88  ReportWasNotRequested   VALUE 'N'CharField.
		public CharField ReSortSel = new CharField('A');//88  SortOptionA              VALUE 'A'CharField.
		//88  SortOptionB              VALUE 'B'CharField.
		//88  SortOptionC              VALUE 'C'CharField.
		//88  SortOptionD              VALUE 'D'CharField.
		public CharField ReFiche = new CharField();//88  PrintFicheOnly           VALUE 'Y'CharField.
		//88  DoNotPrintFiche         VALUE 'N'CharField.
		//88  BothFicheAndReport      VALUE 'B'CharField.
		public class ReFromDateType : Record
		{
			public StrField ReFCc = new StrField(2);
			public StrField ReFYy = new StrField(2);
			public StrField ReFMm = new StrField(2);
			public StrField ReFDd = new StrField(2);
		}
		public ReFromDateType ReFromDate = new ReFromDateType();
		public class ReThruDateType : Record
		{
			public StrField ReTCc = new StrField(2);
			public StrField ReTYy = new StrField(2);
			public StrField ReTMm = new StrField(2);
			public StrField ReTDd = new StrField(2);
		}
		public ReThruDateType ReThruDate = new ReThruDateType();
		public StrField ReLogNbr = new StrField(4);
		public CharField ReMo13 = new CharField();
		public class ReReqDateType : Record
		{
			public StrField ReReqCc = new StrField(2);
			public StrField ReReqYy = new StrField(2);
			public StrField ReReqMm = new StrField(2);
			public StrField ReReqDd = new StrField(2);
		}
		public ReReqDateType ReReqDate = new ReReqDateType();
		public IntField ReSecLvl = new IntField(2);
		public class HdrtrlUnitNameLineType : Record
		{
			public StrField Filler236 = new StrField(11);
			public StrField HdrtrlEffDate = new StrField(8);
			public StrField Filler237 = new StrField(3);
			public StrField HdrtrlApplRpt = new StrField(11);
			public StrField Filler238 = new StrField(17);
			public StrField HdrtrlUnitNum = new StrField(5);
			public StrField Filler239 = new StrField(3);
			public StrField HdrtrlUnitName = new StrField(24);
			public StrField Filler240 = new StrField(13);
			public StrField HdrtrlCoIdLabel = new StrField(7);
			public StrField HdrtrlCoId = new StrField(5);
			public StrField Filler241 = new StrField(13);
			public StrField HdrtrlPageLit = new StrField(4);
			public StrField Filler242 = new StrField(9);
		}
		public HdrtrlUnitNameLineType HdrtrlUnitNameLine = new HdrtrlUnitNameLineType();
		public class HdrtrlTitleLineType : Record
		{
			public StrField Filler243 = new StrField(10);
			public StrField HdrtrlSubunitNum = new StrField(5);
			public StrField Filler244 = new StrField(3);
			public StrField HdrtrlSubunitName = new StrField(8);
			public StrField Filler245 = new StrField(26);
			public StrField HdrtrlTitle = new StrField(30);
			public StrField Filler246 = new StrField(51);
		}
		public HdrtrlTitleLineType HdrtrlTitleLine = new HdrtrlTitleLineType();
		public StrField Filler247 = new StrField(133);
		public StrField Filler248 = new StrField(133);
		public CharField HdrtrlSubunitProcessInd = new CharField();
		public StrField HdrtrlSubunitNumber = new StrField(4);
		public CharField HdrtrlSubunitPrt = new CharField();//88  PrintConsolAndSubunits    VALUE '1'CharField.
		//88  PrintConsolOnly            VALUE '2'CharField.
		//88  PrintSubunitsOnly          VALUE '3'CharField.
		public StrField HdrtrlSystemCode = new StrField(2);
		public CharField HdrtrlChargebackInd = new CharField();
		public StrField HdrtrlOverRmtid = new StrField(5);
		public CharField HdrtrlInventoryReq = new CharField();
		public StrField HdrtrlCoIdNumber = new StrField(5);
		public StrField Hdrtrl_5DigitUnit = new StrField(5);
		public StrField Hdrtrl_5DigitSubunit = new StrField(5);
		public CharField HdrtrlBillInd = new CharField();
		public CharField HdrtrlFormatOnly = new CharField();
		public StrField Filler249 = new StrField(109);
	}
}
