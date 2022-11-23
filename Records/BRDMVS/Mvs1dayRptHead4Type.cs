using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Mvs1dayRptHead4Type : Record
	{
		public StrField Filler155 = new StrField(2);
		public StrField Filler156 = new StrField(13, "PATIENT NAME/");
		public StrField Filler157 = new StrField(12);
		public StrField Filler158 = new StrField(9, "ENTER DT/");
		public CharField Filler159 = new CharField();
		public StrField Filler160 = new StrField(10, "HOLD IND  ");
		public StrField Filler161 = new StrField(6, "USERID");
		public StrField Filler162 = new StrField(8);
		public StrField Filler163 = new StrField(10, "HOLD RSN");
		/*
		      *    05  FILLER               PIC X(97) VALUE SPACES.
		      *    05  FILLER               PIC X(62) VALUE SPACES.
		           */
		public StrField Filler164 = new StrField(23);
		public StrField Filler165 = new StrField(3, "ICD");
		public StrField Filler166 = new StrField(34);
	}
}
