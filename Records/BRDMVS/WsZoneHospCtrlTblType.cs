using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class WsZoneHospCtrlTblType : Record
	{
		public StrField Filler123 = new StrField(4);
		public class WsZoneHospitalControlType : Record
		{
			public IntField WsZoneHospCount = new IntField(3, true);
			public class WsZoneAllHospsType : Record
			{
				public class WsZoneHospTableType : Record
				{
					public WsZoneHospTableType()
					{
						Filler124.Redefine(WsZoneHospNumb);
						WsZoneHospAlpha.Redefine(WsZoneHospNumb);
					}
					public IntField WsZoneHospNumb = new IntField(5);
					public class Filler124Type : Record
					{
						public StrField WsZoneHospNumber = new StrField(5);
					}
					public Filler124Type Filler124 = new Filler124Type();
					public class WsZoneHospAlphaType : Record
					{
						public CharField WsZoneHospType = new CharField();
						public IntField WsZoneHospCode = new IntField(4);
					}
					public WsZoneHospAlphaType WsZoneHospAlpha = new WsZoneHospAlphaType();
				}
				public WsZoneHospTableType[] WsZoneHospTable = (from occurs in Enumerable.Range(1, 75) select new WsZoneHospTableType()).ToArray();
				public class WsZoneHospCloseTableType : Record
				{
					public IntField WsZoneHospCloseIndicator = new IntField(1);
				}
				public WsZoneHospCloseTableType[] WsZoneHospCloseTable = (from occurs in Enumerable.Range(1, 75) select new WsZoneHospCloseTableType()).ToArray();
			}
			public WsZoneAllHospsType WsZoneAllHosps = new WsZoneAllHospsType();
			public StrField Filler125 = new StrField(25);
			public IntField WsZoneRecordNumber = new IntField(3, true);
			public IntField WsZoneRecordCount = new IntField(3, true);
		}
		public WsZoneHospitalControlType WsZoneHospitalControl = new WsZoneHospitalControlType();
	}
}
