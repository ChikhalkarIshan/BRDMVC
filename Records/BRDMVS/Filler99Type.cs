using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Filler99Type : Record
	{
		public Filler99Type()
		{
			AsPa02ExtendedHospCtrl.Redefine(AsZn02ExtendedHospCtrl);
			Filler101.Redefine(AsZn02ExtendedHospCtrl);
		}
		public StrField Filler100 = new StrField(4);//88  ExtendedControl_02          VALUE "ZN02"StrField.
		//88  Zn02ExtendedControl        VALUE "ZN02"StrField.
		//88  Pa02ExtendedControl        VALUE "PA02"StrField.
		public StrField AsZn02ExtendedHospCtrl = new StrField(571);
		public StrField AsPa02ExtendedHospCtrl = new StrField(571);
		public class Filler101Type : Record
		{
			public StrField Filler102 = new StrField(2);
			public class AsQmirFormatTblType : Record
			{
				public IntField[] AsQmirFormat = (from occurs in Enumerable.Range(1, 75) select new IntField(2)).ToArray();
			}
			public AsQmirFormatTblType AsQmirFormatTbl = new AsQmirFormatTblType();
			public StrField Filler103 = new StrField(419);
		}
		public Filler101Type Filler101 = new Filler101Type();
	}
}
