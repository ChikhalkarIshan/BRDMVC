using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class WsDc01PreliminaryTableType : Record
	{
		public StrField Filler133 = new StrField(4);//88  Dc01PreliminaryDates       VALUE "DC01"StrField.
		public class WsPreliminaryDateIndicesType : Record
		{
			public IntField WsDc01HcaIndx = new IntField(3, true);
			public IntField WsDc01QmrIndx = new IntField(3, true);
			public IntField WsDc01HpcIndx = new IntField(3, true);
			public IntField WsDc01HtiIndx = new IntField(3, true);
			public IntField WsDc01NonIndx = new IntField(3, true);
			public IntField Filler134 = new IntField(3, true);
			public IntField Filler135 = new IntField(3, true);
			public IntField Filler136 = new IntField(3, true);
			public IntField Filler137 = new IntField(3, true);
			public IntField WsDc01OtrIndx = new IntField(3, true);
		}
		public WsPreliminaryDateIndicesType WsPreliminaryDateIndices = new WsPreliminaryDateIndicesType();
		public class WsDc01PrelimDatesType : Record
		{
			public class Filler138Type : Record
			{
				public IntField WsDc01PrelimDaysPrev = new IntField(3, true);
				public IntField WsDc01PrelimDaysCurr = new IntField(3, true);
				public IntField WsDc01PrelimDaysNext = new IntField(3, true);
				public StrField WsDc01PrelimDatePrev = new StrField(8);
				public StrField WsDc01PrelimDateCurr = new StrField(8);
				public StrField WsDc01PrelimDateNext = new StrField(8);
			}
			public Filler138Type[] Filler138 = (from occurs in Enumerable.Range(1, 10) select new Filler138Type()).ToArray();
		}
		public WsDc01PrelimDatesType WsDc01PrelimDates = new WsDc01PrelimDatesType();
		public StrField Filler139 = new StrField(251);
	}
}
