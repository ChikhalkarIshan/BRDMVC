using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class WsDc02FinalTableType : Record
	{
		public StrField Filler140 = new StrField(4);//88  Dc02FinalDates             VALUE "DC02"StrField.
		public class WsFinalDateIndicesType : Record
		{
			public IntField WsDc02HcaIndx = new IntField(3, true);
			public IntField WsDc02QmrIndx = new IntField(3, true);
			public IntField WsDc02HpcIndx = new IntField(3, true);
			public IntField WsDc02HtiIndx = new IntField(3, true);
			public IntField WsDc02NonIndx = new IntField(3, true);
			public IntField Filler141 = new IntField(3, true);
			public IntField Filler142 = new IntField(3, true);
			public IntField Filler143 = new IntField(3, true);
			public IntField Filler144 = new IntField(3, true);
			public IntField WsDc02OtrIndx = new IntField(3, true);
		}
		public WsFinalDateIndicesType WsFinalDateIndices = new WsFinalDateIndicesType();
		public class WsDc02FinalDatesType : Record
		{
			public class Filler145Type : Record
			{
				public IntField WsDc02FinalDaysPrev = new IntField(3, true);
				public IntField WsDc02FinalDaysCurr = new IntField(3, true);
				public IntField WsDc02FinalDaysNext = new IntField(3, true);
				public StrField WsDc02FinalDatePrev = new StrField(8);
				public StrField WsDc02FinalDateCurr = new StrField(8);
				public StrField WsDc02FinalDateNext = new StrField(8);
			}
			public Filler145Type[] Filler145 = (from occurs in Enumerable.Range(1, 10) select new Filler145Type()).ToArray();
		}
		public WsDc02FinalDatesType WsDc02FinalDates = new WsDc02FinalDatesType();
		public StrField Filler146 = new StrField(251);
	}
}
