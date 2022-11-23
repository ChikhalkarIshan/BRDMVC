using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class ErrorCodeType : Record
	{
		public StrField ErrorSystemName = new StrField(2);
		public IntField ErrorMsgNum = new IntField(3);
	}
}
