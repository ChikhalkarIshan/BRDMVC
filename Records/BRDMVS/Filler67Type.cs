using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Filler67Type : Record
	{
		public StrField Filler68 = new StrField(4);//88  DateControl                 VALUE "DATE"StrField.
		public class AsZoneDateControlType : Record
		{
			public AsZoneDateControlType()
			{
				AsZoneRunDateAlpha.Redefine(AsZoneRunDate);
				AsZoneRunTimeAlpha.Redefine(AsZoneRunTime);
				Filler69.Redefine(AsZoneEffDate);
				AsZoneEffDateAlpha.Redefine(AsZoneEffDate);
				AsZoneAcctPeriodAlpha.Redefine(AsZoneAcctPeriod);
				Filler85.Redefine(AsZonePrevPrelimDate);
				Filler86.Redefine(AsZonePrevFinalDate);
				Filler87.Redefine(AsZoneNextPrelimDate);
				Filler88.Redefine(AsZoneNextFinalDate);
				AsZoneProcessGroup.Redefine(AsZoneDb2Packageset);
			}
			public IntField AsZoneRunIndicator = new IntField(1);//88  ZoneProdRunBill       VALUE 0IntField.
			//88  ZoneProdRerunBill     VALUE 1IntField.
			//88  ZoneOperRerunNobill   VALUE 2IntField.
			//88  ZoneDevlRunNobill     VALUE 3IntField.
			//88  ValidRunIndicator      VALUE 0 THRU 3IntField.
			public IntField AsZoneRunDate = new IntField(8);
			public class AsZoneRunDateAlphaType : Record
			{
				public class AsZoneRunYyyyType : Record
				{
					public IntField AsZoneRunCentury = new IntField(2);
					public IntField AsZoneRunYear = new IntField(2);
				}
				public AsZoneRunYyyyType AsZoneRunYyyy = new AsZoneRunYyyyType();
				public IntField AsZoneRunMonth = new IntField(2);
				public IntField AsZoneRunDay = new IntField(2);
			}
			public AsZoneRunDateAlphaType AsZoneRunDateAlpha = new AsZoneRunDateAlphaType();
			public IntField AsZoneRunTime = new IntField(6);
			public class AsZoneRunTimeAlphaType : Record
			{
				public IntField AsZoneRunHour = new IntField(2);
				public IntField AsZoneRunMinutes = new IntField(2);
				public IntField AsZoneRunSeconds = new IntField(2);
			}
			public AsZoneRunTimeAlphaType AsZoneRunTimeAlpha = new AsZoneRunTimeAlphaType();
			public IntField AsZoneEffDate = new IntField(8);
			public class Filler69Type : Record
			{
				public IntField Filler70 = new IntField(2);
				public IntField AsZoneEffYymmdd = new IntField(6);
			}
			public Filler69Type Filler69 = new Filler69Type();
			public class AsZoneEffDateAlphaType : Record
			{
				public class AsZoneEffYyyyType : Record
				{
					public IntField AsZoneEffCentury = new IntField(2);
					public IntField AsZoneEffYear = new IntField(2);
				}
				public AsZoneEffYyyyType AsZoneEffYyyy = new AsZoneEffYyyyType();
				public class AsZoneEffMmddType : Record
				{
					public IntField AsZoneEffMonth = new IntField(2);
					public IntField AsZoneEffDay = new IntField(2);
				}
				public AsZoneEffMmddType AsZoneEffMmdd = new AsZoneEffMmddType();
			}
			public AsZoneEffDateAlphaType AsZoneEffDateAlpha = new AsZoneEffDateAlphaType();
			public IntField AsZoneAcctPeriod = new IntField(6);
			public class AsZoneAcctPeriodAlphaType : Record
			{
				public class AsZoneAcctYyyyType : Record
				{
					public IntField AsZoneAcctCentury = new IntField(2);
					public IntField AsZoneAcctYear = new IntField(2);
				}
				public AsZoneAcctYyyyType AsZoneAcctYyyy = new AsZoneAcctYyyyType();
				public IntField AsZoneAcctMonth = new IntField(2);
			}
			public AsZoneAcctPeriodAlphaType AsZoneAcctPeriodAlpha = new AsZoneAcctPeriodAlphaType();
			public IntField AsZonePeriodStatus = new IntField(1);//88  ZoneNormalProcessing   VALUE 0IntField.
			//88  ZonePreliminaryClose   VALUE 1IntField.
			//88  ZoneInterimProcessing  VALUE 2IntField.
			//88  ZoneFinalClose         VALUE 3IntField.
			//88  ZoneOicClose           VALUE 4IntField.
			//88  ZoneAlternateClose     VALUE 5IntField.
			public StrField AsZoneDayOfWeek = new StrField(9);//88  TodayIsSunday          VALUE "SUNDAY   "StrField.
			//88  TodayIsMonday          VALUE "MONDAY   "StrField.
			//88  TodayIsTuesday         VALUE "TUESDAY  "StrField.
			//88  TodayIsWednesday       VALUE "WEDNESDAY"StrField.
			//88  TodayIsThursday        VALUE "THURSDAY "StrField.
			//88  TodayIsFriday          VALUE "FRIDAY   "StrField.
			//88  TodayIsSaturday        VALUE "SATURDAY "StrField.
			public CharField AsZoneEvenOddWeek = new CharField();//88  WeekIsEven             VALUE 'E'CharField.
			//88  WeekIsOdd              VALUE 'O'CharField.
			public CharField AsZoneZone = new CharField();
			public class AsZoneExtendedDateControlType : Record
			{
				public AsZoneExtendedDateControlType()
				{
					AsZoneEndOfMonthDate.Redefine(AsZoneAccountingPeriodDate);
					Filler72.Redefine(AsZoneEndOfMonthDate);
					Filler73.Redefine(AsZonePreliminaryCloseDate);
					AsZonePrelimDate.Redefine(AsZonePreliminaryCloseDate);
					Filler74.Redefine(AsZonePreliminaryCloseDate);
					Filler76.Redefine(AsZoneFinalCloseDate);
					Filler77.Redefine(AsZoneFinalCloseDate);
					Filler79.Redefine(AsZoneFirstWeeklyDate);
					Filler80.Redefine(AsZoneFirstBiWeeklyDate);
					Filler81.Redefine(AsZoneOicManFinalDate);
					Filler82.Redefine(AsZoneLateFinalDate);
				}
				public class AsZoneAccountingPeriodDateType : Record
				{
					public class AsZoneAcctYrMthType : Record
					{
						public IntField Filler71 = new IntField(2);
						public IntField AsZoneAcctPer = new IntField(4);
					}
					public AsZoneAcctYrMthType AsZoneAcctYrMth = new AsZoneAcctYrMthType();
					public IntField AsZoneAcctDay = new IntField(2);
				}
				public AsZoneAccountingPeriodDateType AsZoneAccountingPeriodDate = new AsZoneAccountingPeriodDateType();
				public IntField AsZoneEndOfMonthDate = new IntField(8);
				public class Filler72Type : Record
				{
					public IntField AsZoneEomCentury = new IntField(2);
					public IntField AsZoneEomYear = new IntField(2);
					public IntField AsZoneEomMonth = new IntField(2);
					public IntField AsZoneEomDay = new IntField(2);
				}
				public Filler72Type Filler72 = new Filler72Type();
				public IntField AsZonePreliminaryCloseDate = new IntField(8);
				public class Filler73Type : Record
				{
					public class AsZonePrelimCcyyType : Record
					{
						public IntField AsZonePrelimCentury = new IntField(2);
						public IntField AsZonePrelimYear = new IntField(2);
					}
					public AsZonePrelimCcyyType AsZonePrelimCcyy = new AsZonePrelimCcyyType();
					public IntField AsZonePrelimMonth = new IntField(2);
					public IntField AsZonePrelimDay = new IntField(2);
				}
				public Filler73Type Filler73 = new Filler73Type();
				public IntField AsZonePrelimDate = new IntField(8);
				public class Filler74Type : Record
				{
					public IntField AsZoneCloseYear = new IntField(4);
					public StrField Filler75 = new StrField(4);
				}
				public Filler74Type Filler74 = new Filler74Type();
				public IntField AsZoneFinalCloseDate = new IntField(8);
				public class Filler76Type : Record
				{
					public class AsZoneFinalCcyyType : Record
					{
						public IntField AsZoneFinalCentury = new IntField(2);
						public IntField AsZoneFinalYear = new IntField(2);
					}
					public AsZoneFinalCcyyType AsZoneFinalCcyy = new AsZoneFinalCcyyType();
					public IntField AsZoneFinalMonth = new IntField(2);
					public IntField AsZoneFinalDay = new IntField(2);
				}
				public Filler76Type Filler76 = new Filler76Type();
				public class Filler77Type : Record
				{
					public StrField Filler78 = new StrField(2);
					public IntField AsZoneFinalYymmdd = new IntField(6);
				}
				public Filler77Type Filler77 = new Filler77Type();
				public IntField AsZoneFirstWeeklyDate = new IntField(8);
				public class Filler79Type : Record
				{
					public IntField AsZone_1stWklyCentury = new IntField(2);
					public IntField AsZone_1stWklyYear = new IntField(2);
					public IntField AsZone_1stWklyMonth = new IntField(2);
					public IntField AsZone_1stWklyDay = new IntField(2);
				}
				public Filler79Type Filler79 = new Filler79Type();
				public IntField AsZoneFirstBiWeeklyDate = new IntField(8);
				public class Filler80Type : Record
				{
					public IntField AsZone_1stBiwklyCentury = new IntField(2);
					public IntField AsZone_1stBiwklyYear = new IntField(2);
					public IntField AsZone_1stBiwklyMonth = new IntField(2);
					public IntField AsZone_1stBiwklyDay = new IntField(2);
				}
				public Filler80Type Filler80 = new Filler80Type();
				public IntField AsZoneOicManFinalDate = new IntField(8);
				public class Filler81Type : Record
				{
					public IntField AsZoneOicManCentury = new IntField(2);
					public IntField AsZoneOicManYear = new IntField(2);
					public IntField AsZoneOicManMonth = new IntField(2);
					public IntField AsZoneOicManDay = new IntField(2);
				}
				public Filler81Type Filler81 = new Filler81Type();
				public IntField AsZoneLateFinalDate = new IntField(8);
				public class Filler82Type : Record
				{
					public IntField AsZoneLateCentury = new IntField(2);
					public IntField AsZoneLateYear = new IntField(2);
					public IntField AsZoneLateMonth = new IntField(2);
					public IntField AsZoneLateDay = new IntField(2);
				}
				public Filler82Type Filler82 = new Filler82Type();
				public StrField Filler83 = new StrField(2);
			}
			public AsZoneExtendedDateControlType AsZoneExtendedDateControl = new AsZoneExtendedDateControlType();
			public class AsZoneZoneValidationsType : Record
			{
				public CharField AsZoneProcessing = new CharField();//88 AsZoneValidated               VALUE 'Y'CharField.
				public CharField AsFincProcessing = new CharField();//88 AsFincValidated               VALUE 'Y'CharField.
				public CharField AsApayProcessing = new CharField();//88 AsApayValidated               VALUE 'Y'CharField.
				public CharField AsPayrProcessing = new CharField();//88 AsPayrValidated               VALUE 'Y'CharField.
				public CharField AsLtbdProcessing = new CharField();//88 AsLtbdValidated               VALUE 'Y'CharField.
				public CharField AsQmirProcessing = new CharField();//88 AsQmirValidated               VALUE 'Y'CharField.
				public StrField Filler84 = new StrField(4);
			}
			public AsZoneZoneValidationsType AsZoneZoneValidations = new AsZoneZoneValidationsType();
			public StrField AsZoneCompanyFinal = new StrField(3);//88 AsZoneAlt                       VALUE "ALT"StrField.
			//88 AsZoneHcs                       VALUE "HCS"StrField.
			//88 AsZoneHti                       VALUE "HTI"StrField.
			//88 AsZoneOic                       VALUE "OIC"StrField.
			public StrField AsZoneYearEndInd = new StrField(2);//88 AsPayrYearEnd                VALUE "YE" "YO"StrField.
			public IntField AsZonePrevPrelimDate = new IntField(8);
			public class Filler85Type : Record
			{
				public IntField AsZonePrevPrelimCentury = new IntField(2);
				public IntField AsZonePrevPrelimYear = new IntField(2);
				public IntField AsZonePrevPrelimMonth = new IntField(2);
				public IntField AsZonePrevPrelimDay = new IntField(2);
			}
			public Filler85Type Filler85 = new Filler85Type();
			public IntField AsZonePrevFinalDate = new IntField(8);
			public class Filler86Type : Record
			{
				public IntField AsZonePrevFinalCentury = new IntField(2);
				public IntField AsZonePrevFinalYear = new IntField(2);
				public IntField AsZonePrevFinalMonth = new IntField(2);
				public IntField AsZonePrevFinalDay = new IntField(2);
			}
			public Filler86Type Filler86 = new Filler86Type();
			public class AsZoneTwoYearCalendarType : Record
			{
				public IntField[] AsZoneEomMedDate = (from occurs in Enumerable.Range(1, 24) select new IntField(7)).ToArray();
			}
			public AsZoneTwoYearCalendarType AsZoneTwoYearCalendar = new AsZoneTwoYearCalendarType();
			public class AsZoneHospCorpTableType : Record
			{
				public CharField[] AsZoneHospCorpIndicator = (from occurs in Enumerable.Range(1, 75) select new CharField()).ToArray();
			}
			public AsZoneHospCorpTableType AsZoneHospCorpTable = new AsZoneHospCorpTableType();
			public IntField AsZoneCurrMonthlyPayroll = new IntField(8);
			public IntField AsZoneNextMonthlyPayroll = new IntField(8);
			public StrField AsZoneCloseSchedule = new StrField(3);
			public IntField AsZoneNextPrelimDate = new IntField(8);
			public class Filler87Type : Record
			{
				public IntField AsZoneNextPrelimCentury = new IntField(2);
				public IntField AsZoneNextPrelimYear = new IntField(2);
				public IntField AsZoneNextPrelimMonth = new IntField(2);
				public IntField AsZoneNextPrelimDay = new IntField(2);
			}
			public Filler87Type Filler87 = new Filler87Type();
			public IntField AsZoneNextFinalDate = new IntField(8);
			public class Filler88Type : Record
			{
				public IntField AsZoneNextFinalCentury = new IntField(2);
				public IntField AsZoneNextFinalYear = new IntField(2);
				public IntField AsZoneNextFinalMonth = new IntField(2);
				public IntField AsZoneNextFinalDay = new IntField(2);
			}
			public Filler88Type Filler88 = new Filler88Type();
			public IntField AsZoneDaysToPrelim = new IntField(3, true);
			public CharField AsZoneDb2Packageset = new CharField();
			public CharField AsZoneProcessGroup = new CharField();
			public StrField Filler89 = new StrField(67);
		}
		public AsZoneDateControlType AsZoneDateControl = new AsZoneDateControlType();
	}
}
