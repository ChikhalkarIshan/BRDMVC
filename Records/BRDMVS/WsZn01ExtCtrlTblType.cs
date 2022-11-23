using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class WsZn01ExtCtrlTblType : Record
	{
		public StrField Filler129 = new StrField(6);
		public class WsPsycProcessTblType : Record
		{
			public CharField[] WsPsycProcessInd = (from occurs in Enumerable.Range(1, 75) select new CharField()).ToArray();
		}
		public WsPsycProcessTblType WsPsycProcessTbl = new WsPsycProcessTblType();
		public class WsFyemCloseTblType : Record
		{
			public IntField[] WsFyemMonth = (from occurs in Enumerable.Range(1, 75) select new IntField(2)).ToArray();
		}
		public WsFyemCloseTblType WsFyemCloseTbl = new WsFyemCloseTblType();
		public class WsMyemCloseTblType : Record
		{
			public IntField[] WsMyemMonth = (from occurs in Enumerable.Range(1, 75) select new IntField(2)).ToArray();
		}
		public WsMyemCloseTblType WsMyemCloseTbl = new WsMyemCloseTblType();
		public StrField Filler130 = new StrField(29);
	}
}
