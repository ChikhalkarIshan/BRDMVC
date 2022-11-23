using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class WsZn02ExtCtrlTblType : Record
	{
		public StrField Filler131 = new StrField(6);
		public class WsQmirFormatTblType : Record
		{
			public IntField[] WsQmirFormat = (from occurs in Enumerable.Range(1, 75) select new IntField(2)).ToArray();
		}
		public WsQmirFormatTblType WsQmirFormatTbl = new WsQmirFormatTblType();
		public StrField Filler132 = new StrField(254);
	}
}
