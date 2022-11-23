using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class EditErrorsType : Record
	{
		public class GenericNonDb2FileIOErrorType : Record
		{
			public IntField HospNotFound = new IntField(4, +001, true);
			public IntField FirstOpenError = new IntField(4, +051, true);
			public IntField BadFirstRead = new IntField(4, +057, true);
			public IntField MissingRecord = new IntField(4, +120, true);
			public IntField DailyUpdateError = new IntField(4, +136, true);
			public IntField FileDateNotEq = new IntField(4, +102, true);
		}
		public GenericNonDb2FileIOErrorType GenericNonDb2FileIOError = new GenericNonDb2FileIOErrorType();
		public class HeaderTrailerErrorsType : Record
		{
			public IntField HudhtbOpenEr = new IntField(4, +050, true);
			public IntField HudhtbStartEr = new IntField(4, +052, true);
			public IntField HudhtbReadEr = new IntField(4, +056, true);
			public IntField HudhtbCloseEr = new IntField(4, +068, true);
			public IntField HudhtbBadParam = new IntField(4, +201, true);
			public IntField HudhtbDdMissing = new IntField(4, +202, true);
			public IntField HudhtbDdnameEr = new IntField(4, +203, true);
			public IntField HudhtbNoRecord = new IntField(4, +205, true);
			public IntField HudhtbNoMatch = new IntField(4, +206, true);
			public IntField HudhtbUnitMissing = new IntField(4, +207, true);
			public IntField HudhtbReadGeninfo = new IntField(4, +155, true);
			public IntField HudhtbCloseGeninfo = new IntField(4, +157, true);
			public IntField HudhtbUnknownEr = new IntField(4, +200, true);
		}
		public HeaderTrailerErrorsType HeaderTrailerErrors = new HeaderTrailerErrorsType();
	}
}
