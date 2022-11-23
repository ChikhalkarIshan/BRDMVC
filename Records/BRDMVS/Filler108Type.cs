using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Filler108Type : Record
	{
		public StrField Filler109 = new StrField(4);//88  GledControl                 VALUE "GLED"StrField.
		//88  GledZone                    VALUE "GLZN"StrField.
		public StrField Filler110 = new StrField(2);
		public class AsGledProcessTblType : Record
		{
			public CharField[] AsGledProcessInd = (from occurs in Enumerable.Range(1, 75) select new CharField()).ToArray();
		}
		public AsGledProcessTblType AsGledProcessTbl = new AsGledProcessTblType();
		public StrField Filler111 = new StrField(494);
	}
}
