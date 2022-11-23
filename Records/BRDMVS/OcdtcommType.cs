using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class OcdtcommType : Record
	{
		public OcdtcommType()
		{
			OcdtNumDaysFromCurr.Redefine(OcdtNumDaysFromCurrFill);
		}
		public class OcdtStdDatesType : Record
		{
			public class OcdtUserDateType : Record
			{
				public IntField OcdtUserMm = new IntField(2);
				public CharField Filler20 = new CharField('-');
				public IntField OcdtUserDd = new IntField(2);
				public CharField Filler21 = new CharField('-');
				public IntField OcdtUserYy = new IntField(2);
			}
			public OcdtUserDateType OcdtUserDate = new OcdtUserDateType();
			public class OcdtCurrDateType : Record
			{
				public IntField OcdtCurrMm = new IntField(2);
				public CharField Filler22 = new CharField('-');
				public IntField OcdtCurrDd = new IntField(2);
				public CharField Filler23 = new CharField('-');
				public IntField OcdtCurrYy = new IntField(2);
			}
			public OcdtCurrDateType OcdtCurrDate = new OcdtCurrDateType();
		}
		public OcdtStdDatesType OcdtStdDates = new OcdtStdDatesType();
		public class OcdtDb2DatesType : Record
		{
			public class OcdtDb2DateType : Record
			{
				public IntField OcdtDb2Cc = new IntField(2);
				public IntField OcdtDb2Yy = new IntField(2);
				public CharField Filler24 = new CharField('-');
				public IntField OcdtDb2Mm = new IntField(2);
				public CharField Filler25 = new CharField('-');
				public IntField OcdtDb2Dd = new IntField(2);
			}
			public OcdtDb2DateType OcdtDb2Date = new OcdtDb2DateType();
			public class OcdtCurrDb2DateType : Record
			{
				public IntField OcdtCurrDb2Cc = new IntField(2);
				public IntField OcdtCurrDb2Yy = new IntField(2);
				public CharField Filler26 = new CharField('-');
				public IntField OcdtCurrDb2Mm = new IntField(2);
				public CharField Filler27 = new CharField('-');
				public IntField OcdtCurrDb2Dd = new IntField(2);
			}
			public OcdtCurrDb2DateType OcdtCurrDb2Date = new OcdtCurrDb2DateType();
			public IntField OcdtCurrDayOfWeek = new IntField(1);//88  OcdtCurrSunday     VALUES 0 7IntField.
			//88  OcdtCurrMonday     VALUE  1IntField.
			//88  OcdtCurrTuesday    VALUE  2IntField.
			//88  OcdtCurrWednesday  VALUE  3IntField.
			//88  OcdtCurrThursday   VALUE  4IntField.
			//88  OcdtCurrFriday     VALUE  5IntField.
			//88  OcdtCurrSaturday   VALUE  6IntField.
		}
		public OcdtDb2DatesType OcdtDb2Dates = new OcdtDb2DatesType();
		public class OcdtJulianDatesType : Record
		{
			public class OcdtCcjulianDateType : Record
			{
				public IntField OcdtJulianCc = new IntField(2);
				public class OcdtJulianDateType : Record
				{
					public IntField OcdtJulianYy = new IntField(2);
					public CharField Filler28 = new CharField('.');
					public IntField OcdtJulianDdd = new IntField(3);
				}
				public OcdtJulianDateType OcdtJulianDate = new OcdtJulianDateType();
			}
			public OcdtCcjulianDateType OcdtCcjulianDate = new OcdtCcjulianDateType();
			public class OcdtCurrCcjulianDateType : Record
			{
				public IntField OcdtCurrJulianCc = new IntField(2);
				public class OcdtCurrJulianDateType : Record
				{
					public IntField OcdtCurrJulianYy = new IntField(2);
					public CharField Filler29 = new CharField('.');
					public IntField OcdtCurrJulianDdd = new IntField(3);
				}
				public OcdtCurrJulianDateType OcdtCurrJulianDate = new OcdtCurrJulianDateType();
				public class OcdtMmddyyDateType : Record
				{
					public IntField OcdtMmddyyMm = new IntField(2);
					public IntField OcdtMmddyyDd = new IntField(2);
					public IntField OcdtMmddyyYy = new IntField(2);
				}
				public OcdtMmddyyDateType OcdtMmddyyDate = new OcdtMmddyyDateType();
				public class OcdtWccyymmddDateType : Record
				{
					/*
					      *                                         |* WCCYYMMDD *|
					                   */
					public IntField OcdtDayOfWeek = new IntField(1);//88 OcdtSunday       VALUES 0 7IntField.
					//88 OcdtMonday       VALUE  1IntField.
					//88 OcdtTuesday      VALUE  2IntField.
					//88 OcdtWednesday    VALUE  3IntField.
					//88 OcdtThursday     VALUE  4IntField.
					//88 OcdtFriday       VALUE  5IntField.
					//88 OcdtSaturday     VALUE  6IntField.
					public class OcdtCcyymmddDateType : Record
					{
						public IntField OcdtCcyymmddCc = new IntField(2);
						public class OcdtYymmddDateType : Record
						{
							public IntField OcdtCcyymmddYy = new IntField(2);
							public IntField OcdtCcyymmddMm = new IntField(2);
							public IntField OcdtCcyymmddDd = new IntField(2);
						}
						public OcdtYymmddDateType OcdtYymmddDate = new OcdtYymmddDateType();
					}
					public OcdtCcyymmddDateType OcdtCcyymmddDate = new OcdtCcyymmddDateType();
				}
				public OcdtWccyymmddDateType OcdtWccyymmddDate = new OcdtWccyymmddDateType();
				public class OcdtReportManagerDateType : Record
				{
					public IntField OcdtMmddccyyMm = new IntField(2);
					public IntField OcdtMmddccyyDd = new IntField(2);
					public IntField OcdtMmddccyyCc = new IntField(2);
					public IntField OcdtMmddccyyYy = new IntField(2);
				}
				public OcdtReportManagerDateType OcdtReportManagerDate = new OcdtReportManagerDateType();
				public class OcdtUserTimeType : Record
				{
					public IntField OcdtUserTmHh = new IntField(2);
					public CharField Filler30 = new CharField(':');
					public IntField OcdtUserTmMm = new IntField(2);
					public CharField Filler31 = new CharField(':');
					public IntField OcdtUserTmSs = new IntField(2);
				}
				public OcdtUserTimeType OcdtUserTime = new OcdtUserTimeType();
				public class OcdtCurrTimeType : Record
				{
					public IntField OcdtCurrTmHh = new IntField(2);
					public CharField Filler32 = new CharField(':');
					public IntField OcdtCurrTmMm = new IntField(2);
					public CharField Filler33 = new CharField(':');
					public IntField OcdtCurrTmSs = new IntField(2);
				}
				public OcdtCurrTimeType OcdtCurrTime = new OcdtCurrTimeType();
				public class OcdtDb2TimeType : Record
				{
					public IntField OcdtDb2TmHh = new IntField(2);
					public CharField Filler34 = new CharField('.');
					public IntField OcdtDb2TmMm = new IntField(2);
					public CharField Filler35 = new CharField('.');
					public IntField OcdtDb2TmSs = new IntField(2);
				}
				public OcdtDb2TimeType OcdtDb2Time = new OcdtDb2TimeType();
				public class OcdtCurrDb2TimeType : Record
				{
					public IntField OcdtCurrDb2TmHh = new IntField(2);
					public CharField Filler36 = new CharField('.');
					public IntField OcdtCurrDb2TmMm = new IntField(2);
					public CharField Filler37 = new CharField('.');
					public IntField OcdtCurrDb2TmSs = new IntField(2);
				}
				public OcdtCurrDb2TimeType OcdtCurrDb2Time = new OcdtCurrDb2TimeType();
				public class OcdtDb2TimestampType : Record
				{
					public class OcdtDb2TimestampDateType : Record
					{
						public IntField OcdtDb2TsDtCc = new IntField(2);
						public IntField OcdtDb2TsDtYy = new IntField(2);
						public CharField Filler38 = new CharField('-');
						public IntField OcdtDb2TsDtMm = new IntField(2);
						public CharField Filler39 = new CharField('-');
						public IntField OcdtDb2TsDtDd = new IntField(2);
					}
					public OcdtDb2TimestampDateType OcdtDb2TimestampDate = new OcdtDb2TimestampDateType();
					public CharField Filler40 = new CharField('-');
					public class OcdtDb2TimestampTimeType : Record
					{
						public IntField OcdtDb2TsTmHh = new IntField(2);
						public CharField Filler41 = new CharField('.');
						public IntField OcdtDb2TsTmMm = new IntField(2);
						public CharField Filler42 = new CharField('.');
						public IntField OcdtDb2TsTmSs = new IntField(2);
						public CharField Filler43 = new CharField('.');
						public IntField OcdtDb2TsTmTt = new IntField(5);
						/*
						      *                                     |* MM-DD-CCYY *|
						                   */
						public IntField Ocdt_2000Mm = new IntField(2);
						public CharField Filler44 = new CharField('-');
						public IntField Ocdt_2000Dd = new IntField(2);
						public CharField Filler45 = new CharField('-');
						public IntField Ocdt_2000Cc = new IntField(2);
						public IntField Ocdt_2000Yy = new IntField(2);
					}
					public OcdtDb2TimestampTimeType OcdtDb2TimestampTime = new OcdtDb2TimestampTimeType();
				}
				public OcdtDb2TimestampType OcdtDb2Timestamp = new OcdtDb2TimestampType();
				public class Ocdt_2000DateType : Record
				{
					public IntField Ocdt_2000Mm = new IntField(2);
					public CharField Filler46 = new CharField('-');
					public IntField Ocdt_2000Dd = new IntField(2);
					public CharField Filler47 = new CharField('-');
					public IntField Ocdt_2000Cc = new IntField(2);
					public IntField Ocdt_2000Yy = new IntField(2);
				}
				public Ocdt_2000DateType Ocdt_2000Date = new Ocdt_2000DateType();
				/*
				      *----ERROR MESSAGES
				               */
				public StrField OcdtErrorCode = new StrField(2, "  "); //88  OcdtPassedEdit
				//VALUE "  " "LD" "UD" "WW"StrField.
				//88  OcdtPerfectEdit                VALUE "  "StrField.
				//88  OcdtLowDate                    VALUE "LD"StrField.
				//88  OcdtUserDateReformatted       VALUE "UD"StrField.
				//88  OcdtWrongDayOfWeek           VALUE "WW"StrField.
				//88  OcdtNothingWasPassed          VALUE "XX"StrField.
				//88  OcdtFailedEdit
				//VALUE "IL" "ID" "IT" "IX" "IW" "ND" "NT" "NX" "NW"StrField.
				//88  OcdtInvalidLength              VALUE "IL"StrField.
				//88  OcdtInvalidDate                VALUE "ID"StrField.
				//88  OcdtInvalidTime                VALUE "IT"StrField.
				//88  OcdtInvalidTimestamp           VALUE "IX"StrField.
				//88  OcdtInvalidDayOfWeek         VALUE "IW"StrField.
				//88  OcdtNonNumericDate            VALUE "ND"StrField.
				//88  OcdtNonNumericTime            VALUE "NT"StrField.
				//88  OcdtNonNumericTimestamp       VALUE "NX"StrField.
				//88  OcdtNonNumericDayOfWeek     VALUE "NW"StrField.
			}
			public OcdtCurrCcjulianDateType OcdtCurrCcjulianDate = new OcdtCurrCcjulianDateType();
		}
		public OcdtJulianDatesType OcdtJulianDates = new OcdtJulianDatesType();
		public class OcdtAbbreviatedDatesType : Record
		{
			public class OcdtMmddyyDateType : Record
			{
				public IntField OcdtMmddyyMm = new IntField(2);
				public IntField OcdtMmddyyDd = new IntField(2);
				public IntField OcdtMmddyyYy = new IntField(2);
			}
			public OcdtMmddyyDateType OcdtMmddyyDate = new OcdtMmddyyDateType();
			public class OcdtWccyymmddDateType : Record
			{
				/*
				      *                                         |* WCCYYMMDD *|
				                   */
				public IntField OcdtDayOfWeek = new IntField(1);//88 OcdtSunday       VALUES 0 7IntField.
				//88 OcdtMonday       VALUE  1IntField.
				//88 OcdtTuesday      VALUE  2IntField.
				//88 OcdtWednesday    VALUE  3IntField.
				//88 OcdtThursday     VALUE  4IntField.
				//88 OcdtFriday       VALUE  5IntField.
				//88 OcdtSaturday     VALUE  6IntField.
				public class OcdtCcyymmddDateType : Record
				{
					public IntField OcdtCcyymmddCc = new IntField(2);
					public class OcdtYymmddDateType : Record
					{
						public IntField OcdtCcyymmddYy = new IntField(2);
						public IntField OcdtCcyymmddMm = new IntField(2);
						public IntField OcdtCcyymmddDd = new IntField(2);
					}
					public OcdtYymmddDateType OcdtYymmddDate = new OcdtYymmddDateType();
				}
				public OcdtCcyymmddDateType OcdtCcyymmddDate = new OcdtCcyymmddDateType();
			}
			public OcdtWccyymmddDateType OcdtWccyymmddDate = new OcdtWccyymmddDateType();
			public class OcdtReportManagerDateType : Record
			{
				public IntField OcdtMmddccyyMm = new IntField(2);
				public IntField OcdtMmddccyyDd = new IntField(2);
				public IntField OcdtMmddccyyCc = new IntField(2);
				public IntField OcdtMmddccyyYy = new IntField(2);
			}
			public OcdtReportManagerDateType OcdtReportManagerDate = new OcdtReportManagerDateType();
		}
		public OcdtAbbreviatedDatesType OcdtAbbreviatedDates = new OcdtAbbreviatedDatesType();
		public class OcdtTimesType : Record
		{
			public class OcdtUserTimeType : Record
			{
				public IntField OcdtUserTmHh = new IntField(2);
				public CharField Filler48 = new CharField(':');
				public IntField OcdtUserTmMm = new IntField(2);
				public CharField Filler49 = new CharField(':');
				public IntField OcdtUserTmSs = new IntField(2);
			}
			public OcdtUserTimeType OcdtUserTime = new OcdtUserTimeType();
			public class OcdtCurrTimeType : Record
			{
				public IntField OcdtCurrTmHh = new IntField(2);
				public CharField Filler50 = new CharField(':');
				public IntField OcdtCurrTmMm = new IntField(2);
				public CharField Filler51 = new CharField(':');
				public IntField OcdtCurrTmSs = new IntField(2);
			}
			public OcdtCurrTimeType OcdtCurrTime = new OcdtCurrTimeType();
			public class OcdtDb2TimeType : Record
			{
				public IntField OcdtDb2TmHh = new IntField(2);
				public CharField Filler52 = new CharField('.');
				public IntField OcdtDb2TmMm = new IntField(2);
				public CharField Filler53 = new CharField('.');
				public IntField OcdtDb2TmSs = new IntField(2);
			}
			public OcdtDb2TimeType OcdtDb2Time = new OcdtDb2TimeType();
			public class OcdtCurrDb2TimeType : Record
			{
				public IntField OcdtCurrDb2TmHh = new IntField(2);
				public CharField Filler54 = new CharField('.');
				public IntField OcdtCurrDb2TmMm = new IntField(2);
				public CharField Filler55 = new CharField('.');
				public IntField OcdtCurrDb2TmSs = new IntField(2);
			}
			public OcdtCurrDb2TimeType OcdtCurrDb2Time = new OcdtCurrDb2TimeType();
		}
		public OcdtTimesType OcdtTimes = new OcdtTimesType();
		public class OcdtTimestampsType : Record
		{
			public class OcdtDb2TimestampType : Record
			{
				public class OcdtDb2TimestampDateType : Record
				{
					public IntField OcdtDb2TsDtCc = new IntField(2);
					public IntField OcdtDb2TsDtYy = new IntField(2);
					public CharField Filler56 = new CharField('-');
					public IntField OcdtDb2TsDtMm = new IntField(2);
					public CharField Filler57 = new CharField('-');
					public IntField OcdtDb2TsDtDd = new IntField(2);
				}
				public OcdtDb2TimestampDateType OcdtDb2TimestampDate = new OcdtDb2TimestampDateType();
				public CharField Filler58 = new CharField('-');
				public class OcdtDb2TimestampTimeType : Record
				{
					public IntField OcdtDb2TsTmHh = new IntField(2);
					public CharField Filler59 = new CharField('.');
					public IntField OcdtDb2TsTmMm = new IntField(2);
					public CharField Filler60 = new CharField('.');
					public IntField OcdtDb2TsTmSs = new IntField(2);
					public CharField Filler61 = new CharField('.');
					public IntField OcdtDb2TsTmTt = new IntField(5);
					/*
					      *                                     |* MM-DD-CCYY *|
					                   */
					public IntField Ocdt_2000Mm = new IntField(2);
					public CharField Filler62 = new CharField('-');
					public IntField Ocdt_2000Dd = new IntField(2);
					public CharField Filler63 = new CharField('-');
					public IntField Ocdt_2000Cc = new IntField(2);
					public IntField Ocdt_2000Yy = new IntField(2);
				}
				public OcdtDb2TimestampTimeType OcdtDb2TimestampTime = new OcdtDb2TimestampTimeType();
			}
			public OcdtDb2TimestampType OcdtDb2Timestamp = new OcdtDb2TimestampType();
		}
		public OcdtTimestampsType OcdtTimestamps = new OcdtTimestampsType();
		public class OcdtOtherDatesType : Record
		{
			public class Ocdt_2000DateType : Record
			{
				public IntField Ocdt_2000Mm = new IntField(2);
				public CharField Filler64 = new CharField('-');
				public IntField Ocdt_2000Dd = new IntField(2);
				public CharField Filler65 = new CharField('-');
				public IntField Ocdt_2000Cc = new IntField(2);
				public IntField Ocdt_2000Yy = new IntField(2);
			}
			public Ocdt_2000DateType Ocdt_2000Date = new Ocdt_2000DateType();
		}
		public OcdtOtherDatesType OcdtOtherDates = new OcdtOtherDatesType();
		public StrField OcdtCurrDayName = new StrField(9);
		public StrField OcdtDayName = new StrField(9);
		public StrField OcdtUnformattedDate = new StrField(44);
		public IntField OcdtPackedCcyymmddDate = new IntField(8, true);
		public LongField OcdtFiller_1 = new LongField(10);
		public LongField OcdtFiller_2 = new LongField(10);
		public LongField OcdtFiller_3 = new LongField(10);
		public IntField OcdtFiller_4 = new IntField(8);
		public CharField OcdtCopybookVersion = new CharField();//88  OcdtCopybookVersion_0              VALUE '0'CharField.
		//88  OcdtCopybookVersion_1              VALUE ' 'CharField.
		public StrField OcdtNumDaysFromCurrFill = new StrField(4, " "); //88  OcdtNumDaysNotSet                VALUE " "StrField.
		public IntField OcdtNumDaysFromCurr = new IntField(8, true);
		public CharField OcdtTimeZone = new CharField(' ');//88  OcdtAtlantic                        VALUE 'A'CharField.
		//88  OcdtEastern                         VALUE 'E'CharField.
		//88  OcdtCentral                         VALUE 'C'CharField.
		//88  OcdtMountain                        VALUE 'M'CharField.
		//88  OcdtPacific                         VALUE 'P'CharField.
		//88  OcdtUnspecifiedTimeZone           VALUE ' 'CharField.
		//88  OcdtAlaskan                         VALUE 'L'CharField.
		public class OcdtErrorCodesType : Record
		{
			/*
			      *----ERROR MESSAGES
			               */
			public StrField OcdtErrorCode = new StrField(2, "  "); //88  OcdtPassedEdit
			//VALUE "  " "LD" "UD" "WW"StrField.
			//88  OcdtPerfectEdit                VALUE "  "StrField.
			//88  OcdtLowDate                    VALUE "LD"StrField.
			//88  OcdtUserDateReformatted       VALUE "UD"StrField.
			//88  OcdtWrongDayOfWeek           VALUE "WW"StrField.
			//88  OcdtNothingWasPassed          VALUE "XX"StrField.
			//88  OcdtFailedEdit
			//VALUE "IL" "ID" "IT" "IX" "IW" "ND" "NT" "NX" "NW"StrField.
			//88  OcdtInvalidLength              VALUE "IL"StrField.
			//88  OcdtInvalidDate                VALUE "ID"StrField.
			//88  OcdtInvalidTime                VALUE "IT"StrField.
			//88  OcdtInvalidTimestamp           VALUE "IX"StrField.
			//88  OcdtInvalidDayOfWeek         VALUE "IW"StrField.
			//88  OcdtNonNumericDate            VALUE "ND"StrField.
			//88  OcdtNonNumericTime            VALUE "NT"StrField.
			//88  OcdtNonNumericTimestamp       VALUE "NX"StrField.
			//88  OcdtNonNumericDayOfWeek     VALUE "NW"StrField.
		}
		public OcdtErrorCodesType OcdtErrorCodes = new OcdtErrorCodesType();
	}
}
