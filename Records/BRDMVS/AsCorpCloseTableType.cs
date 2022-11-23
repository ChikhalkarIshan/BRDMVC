using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class AsCorpCloseTableType : Record
	{
		public AsCorpCloseTableType()
		{
			AsCorpFinalDates.Redefine(AsCorpPrelimDates);
		}
		public StrField Filler112 = new StrField(4);//88  CorpPreliminaryDates       VALUE "DC01"StrField.
		//88  CorpFinalDates             VALUE "DC02"StrField.
		public class AsCloseDateIndicesType : Record
		{
			public IntField AsHcaIndx = new IntField(3, true);
			public IntField AsQmrIndx = new IntField(3, true);
			public IntField AsHpcIndx = new IntField(3, true);
			public IntField AsHtiIndx = new IntField(3, true);
			public IntField AsNonIndx = new IntField(3, true);
			public IntField Filler113 = new IntField(3, true);
			public IntField Filler114 = new IntField(3, true);
			public IntField Filler115 = new IntField(3, true);
			public IntField Filler116 = new IntField(3, true);
			public IntField AsOtrIndx = new IntField(3, true);
		}
		public AsCloseDateIndicesType AsCloseDateIndices = new AsCloseDateIndicesType();
		public class AsCorpPrelimDatesType : Record
		{
			public class Filler117Type : Record
			{
				public IntField AsCorpDaysPrev = new IntField(3, true);
				public IntField AsCorpDaysCurr = new IntField(3, true);
				public IntField AsCorpDaysNext = new IntField(3, true);
				public StrField AsCorpPrevPrelim = new StrField(8);
				public StrField AsCorpCurrPrelim = new StrField(8);
				public StrField AsCorpNextPrelim = new StrField(8);
			}
			public Filler117Type[] Filler117 = (from occurs in Enumerable.Range(1, 10) select new Filler117Type()).ToArray();
		}
		public AsCorpPrelimDatesType AsCorpPrelimDates = new AsCorpPrelimDatesType();
		public class AsCorpFinalDatesType : Record
		{
			public class Filler118Type : Record
			{
				public IntField Filler119 = new IntField(3, true);
				public IntField Filler120 = new IntField(3, true);
				public IntField Filler121 = new IntField(3, true);
				public StrField AsCorpPrevFinal = new StrField(8);
				public StrField AsCorpCurrFinal = new StrField(8);
				public StrField AsCorpNextFinal = new StrField(8);
			}
			public Filler118Type[] Filler118 = (from occurs in Enumerable.Range(1, 10) select new Filler118Type()).ToArray();
		}
		public AsCorpFinalDatesType AsCorpFinalDates = new AsCorpFinalDatesType();
		public StrField Filler122 = new StrField(251);
	}
}
