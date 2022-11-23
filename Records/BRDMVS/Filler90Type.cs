using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Filler90Type : Record
	{
		public StrField Filler91 = new StrField(4);//88  AccoutsPayable                 VALUE "APAY"StrField.
		//88  GeneralLedger                  VALUE "GLED"StrField.
		//88  GeneralLedgerZone             VALUE "GLZN"StrField.
		//88  Qmirs                           VALUE "QMIR"StrField.
		//88  Payroll                         VALUE "PAYR"StrField.
		//88  PatientAccounting              VALUE "PACT"StrField.
		//88  LongTermBeds                  VALUE "LTBD"StrField.
		//88  RmrInpatient                   VALUE "RMRI"StrField.
		//88  RmrOutpatient                  VALUE "RMRO"StrField.
		//88  RevenuePackage                 VALUE "RPAK"StrField.
		//88  PsychiatricSystem              VALUE "PSYC"StrField.
		//88  ProcessingZone                 VALUE "ZONE"StrField.
		public class AsZoneHospitalControlType : Record
		{
			public IntField AsZoneHospCount = new IntField(3, true);
			public class AsZoneAllHospsType : Record
			{
				public AsZoneAllHospsType()
				{
					AsZoneHospTable[0].Redefine(AsZoneHospCodes);
					AsZoneHospCloseTable[0].Redefine(AsZoneCloseCodes);
				}
				public StrField AsZoneHospCodes = new StrField(375);
				public class AsZoneHospTableType : Record
				{
					public AsZoneHospTableType()
					{
						Filler92.Redefine(AsZoneHospNumb);
						AsZoneHospAlpha.Redefine(AsZoneHospNumb);
					}
					public IntField AsZoneHospNumb = new IntField(5);
					public class Filler92Type : Record
					{
						public StrField AsZoneHospNumber = new StrField(5);
					}
					public Filler92Type Filler92 = new Filler92Type();
					public class AsZoneHospAlphaType : Record
					{
						public CharField AsZoneHospType = new CharField();
						public IntField AsZoneHospCode = new IntField(4);
					}
					public AsZoneHospAlphaType AsZoneHospAlpha = new AsZoneHospAlphaType();
				}
				public AsZoneHospTableType[] AsZoneHospTable = (from occurs in Enumerable.Range(1, 75) select new AsZoneHospTableType()).ToArray();
				public StrField AsZoneCloseCodes = new StrField(75);
				public class AsZoneHospCloseTableType : Record
				{
					public IntField AsZoneHospCloseIndicator = new IntField(1);
				}
				public AsZoneHospCloseTableType[] AsZoneHospCloseTable = (from occurs in Enumerable.Range(1, 75) select new AsZoneHospCloseTableType()).ToArray();
			}
			public AsZoneAllHospsType AsZoneAllHosps = new AsZoneAllHospsType();
			public StrField Filler93 = new StrField(115);
			public IntField AsZoneRecordNumber = new IntField(3, true);
			public IntField AsZoneRecordCount = new IntField(3, true);
		}
		public AsZoneHospitalControlType AsZoneHospitalControl = new AsZoneHospitalControlType();
	}
}
