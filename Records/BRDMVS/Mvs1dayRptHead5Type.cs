using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Mvs1dayRptHead5Type : Record
	{
		public StrField Filler167 = new StrField(2);
		public StrField Filler168 = new StrField(14, "SUNIT  PAT NUM");
		public StrField Filler169 = new StrField(11);
		public StrField Filler170 = new StrField(8, "ADMIT DT");
		public StrField Filler171 = new StrField(2);
		public StrField Filler172 = new StrField(8, "DISCH DT");
		public StrField Filler173 = new StrField(2);
		public StrField Filler174 = new StrField(5, "IPLAN");
		public StrField Filler175 = new StrField(2);
		public StrField Filler176 = new StrField(7, "FC TYP ");
		public StrField Filler177 = new StrField(16, "SVC  TOTAL CHGS ");
		public StrField Filler178 = new StrField(17, "FBILL DT PRNDIAG");
		public StrField Filler179 = new StrField(4, "VER ");
		public StrField Filler180 = new StrField(13, "PRN DIAG DESC");
		public StrField Filler181 = new StrField(12);
		public StrField Filler182 = new StrField(8, "COMMENTS");
		/*
		      *    05  FILLER               PIC X(11) VALUE SPACES.
		           */
		public StrField Filler183 = new StrField(6);
	}
}
