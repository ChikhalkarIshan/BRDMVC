using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Filler104Type : Record
	{
		public StrField Filler105 = new StrField(4);//88  SubUnitControl             VALUE "SUBU"StrField.
		public StrField Filler106 = new StrField(2);
		public class AsSubuProcessTblType : Record
		{
			public CharField[] AsSubuProcessInd = (from occurs in Enumerable.Range(1, 75) select new CharField()).ToArray();
		}
		public AsSubuProcessTblType AsSubuProcessTbl = new AsSubuProcessTblType();
		public class AsSubuAllHospsType : Record
		{
			public class AsSubuHospTableType : Record
			{
				public AsSubuHospTableType()
				{
					AsSubuHospNumber.Redefine(AsSubuHospNumb);
				}
				public IntField AsSubuHospNumb = new IntField(5);
				public class AsSubuHospNumberType : Record
				{
					public class AsSubuHospAlphaType : Record
					{
						public CharField AsSubuHospType = new CharField();
						public IntField AsSubuHospCode = new IntField(4);
					}
					public AsSubuHospAlphaType AsSubuHospAlpha = new AsSubuHospAlphaType();
				}
				public AsSubuHospNumberType AsSubuHospNumber = new AsSubuHospNumberType();
			}
			public AsSubuHospTableType[] AsSubuHospTable = (from occurs in Enumerable.Range(1, 75) select new AsSubuHospTableType()).ToArray();
		}
		public AsSubuAllHospsType AsSubuAllHosps = new AsSubuAllHospsType();
		public StrField Filler107 = new StrField(119);
	}
}
