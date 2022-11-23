using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class ErrorUnitNumTableType : Record
	{
		public ErrorUnitNumTableType()
		{
			ErrorUnitNumRdef.Redefine(ErrorUnitNum);
		}
		public class ErrorUnitNumType : Record
		{
			public CharField ErrorUnitPrefix = new CharField();
			public IntField ErrorUnitSuffix = new IntField(4);
		}
		public ErrorUnitNumType ErrorUnitNum = new ErrorUnitNumType();
		public class ErrorUnitNumRdefType : Record
		{
			public StrField ErrorUnitWhole = new StrField(5);
		}
		public ErrorUnitNumRdefType ErrorUnitNumRdef = new ErrorUnitNumRdefType();
	}
}
