using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class WsApplHospCtrlTblType : Record
	{
		public StrField Filler126 = new StrField(4);
		public class WsApplHospitalControlType : Record
		{
			public IntField WsApplHospCount = new IntField(3, true);
			public class WsApplAllHospsType : Record
			{
				public class WsApplHospTableType : Record
				{
					public WsApplHospTableType()
					{
						Filler127.Redefine(WsApplHospNumb);
						WsApplHospAlpha.Redefine(WsApplHospNumb);
					}
					public IntField WsApplHospNumb = new IntField(5);
					public class Filler127Type : Record
					{
						public StrField WsApplHospNumber = new StrField(5);
					}
					public Filler127Type Filler127 = new Filler127Type();
					public class WsApplHospAlphaType : Record
					{
						public CharField WsApplHospType = new CharField();
						public IntField WsApplHospCode = new IntField(4);
					}
					public WsApplHospAlphaType WsApplHospAlpha = new WsApplHospAlphaType();
				}
				public WsApplHospTableType[] WsApplHospTable = (from occurs in Enumerable.Range(1, 75) select new WsApplHospTableType()).ToArray();
				public class WsApplHospCloseTableType : Record
				{
					public IntField WsApplHospCloseIndicator = new IntField(1);
				}
				public WsApplHospCloseTableType[] WsApplHospCloseTable = (from occurs in Enumerable.Range(1, 75) select new WsApplHospCloseTableType()).ToArray();
			}
			public WsApplAllHospsType WsApplAllHosps = new WsApplAllHospsType();
			public StrField Filler128 = new StrField(25);
			public IntField WsApplRecordNumber = new IntField(3, true);
			public IntField WsApplRecordCount = new IntField(3, true);
		}
		public WsApplHospitalControlType WsApplHospitalControl = new WsApplHospitalControlType();
	}
}
