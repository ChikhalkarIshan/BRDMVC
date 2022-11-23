using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Mvs1dayRptHead6Type : Record
	{
		public StrField Filler184 = new StrField(2);
		public StrField Filler185 = new StrField(24, new string('=', 24));
		public CharField Filler186 = new CharField(' ');
		public StrField Filler187 = new StrField(8, "========");
		public StrField Filler188 = new StrField(2);
		public StrField Filler189 = new StrField(8, new string('=', 8));
		public StrField Filler190 = new StrField(2);
		public StrField Filler191 = new StrField(18, "====== == === ===");
		public CharField Filler192 = new CharField(' ');
		public StrField Filler193 = new StrField(10, "==");//new string('==', 10));
		public CharField Filler194 = new CharField();
		public StrField Filler195 = new StrField(8, new string('=', 8));
		public CharField Filler196 = new CharField();
		public StrField Filler197 = new StrField(7, new string('=', 7));
		public CharField Filler198 = new CharField(' ');
		public StrField Filler199 = new StrField(4, "=== ");
		public StrField Filler200 = new StrField(24, new string('=', 24));
		public CharField Filler201 = new CharField(' ');
		/*
		      *    05  FILLER               PIC X(12) VALUE ALL '='.
		           */
		public StrField Filler202 = new StrField(7, new string('=', 7));
	}
}
