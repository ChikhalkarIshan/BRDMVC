using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Filler94Type : Record
	{
		public Filler94Type()
		{
			AsPa01ExtendedHospCtrl.Redefine(AsZn01ExtendedHospCtrl);
			Filler96.Redefine(AsZn01ExtendedHospCtrl);
		}
		public StrField Filler95 = new StrField(4);//88  ExtendedControl             VALUE "ZN01"StrField.
		//88  Zn01ExtendedControl        VALUE "ZN01"StrField.
		//88  Pa01ExtendedControl        VALUE "PA01"StrField.
		public StrField AsZn01ExtendedHospCtrl = new StrField(571);
		public StrField AsPa01ExtendedHospCtrl = new StrField(571);
		public class Filler96Type : Record
		{
			public StrField Filler97 = new StrField(2);
			public class AsPsycProcessTblType : Record
			{
				public CharField[] AsPsycProcessInd = (from occurs in Enumerable.Range(1, 75) select new CharField()).ToArray();
			}
			public AsPsycProcessTblType AsPsycProcessTbl = new AsPsycProcessTblType();
			public class AsFyemCloseTblType : Record
			{
				public IntField[] AsFyemMonth = (from occurs in Enumerable.Range(1, 75) select new IntField(2)).ToArray();
			}
			public AsFyemCloseTblType AsFyemCloseTbl = new AsFyemCloseTblType();
			public class AsMyemCloseTblType : Record
			{
				public IntField[] AsMyemMonth = (from occurs in Enumerable.Range(1, 75) select new IntField(2)).ToArray();
			}
			public AsMyemCloseTblType AsMyemCloseTbl = new AsMyemCloseTblType();
			public StrField Filler98 = new StrField(194);
		}
		public Filler96Type Filler96 = new Filler96Type();
	}
}
