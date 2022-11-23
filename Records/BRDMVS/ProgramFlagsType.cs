using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class ProgramFlagsType : Record
	{
		public CharField PfFaEof = new CharField('N');//88  PfFaEofYes                       VALUE 'Y'CharField.
		//88  PfFaEofNo                        VALUE 'N'CharField.
		public CharField PfOutpCsr1Eof = new CharField('N');//88  PfOutpCsr1EofYes                VALUE 'Y'CharField.
		//88  PfOutpCsr1EofNo                 VALUE 'N'CharField.
		public CharField PfOutpCsr2Eof = new CharField('N');//88  PfOutpCsr2EofYes                VALUE 'Y'CharField.
		//88  PfOutpCsr2EofNo                 VALUE 'N'CharField.
		public CharField PfRecordsWritten = new CharField('N');//88  PfRecordsWrittenYes              VALUE 'Y'CharField.
		//88  PfRecordsWrittenNo               VALUE 'N'CharField.
		public CharField PfOutpHasChgs = new CharField('N');//88  PfOutpHasChgsYes                VALUE 'Y'CharField.
		//88  PfOutpHasChgsNo                 VALUE 'N'CharField.
		public CharField PfCssFound = new CharField('N');//88  PfCssFoundYes                    VALUE 'Y'CharField.
		//88  PfCssFoundNo                     VALUE 'N'CharField.
		public CharField PfAdmitDtRange = new CharField('N');//88  PfAdmitDtRangeYes               VALUE 'Y'CharField.
		//88  PfAdmitDtRangeNo                VALUE 'N'CharField.
		public CharField PfPrintInp = new CharField('N');//88  PfPrintInpYes                    VALUE 'Y'CharField.
		//88  PfPrintInpNo                     VALUE 'N'CharField.
		public CharField PfOverlapSection = new CharField('N');//88  PfOverlapSectionYes              VALUE 'Y'CharField.
		//88  PfOverlapSectionNo               VALUE 'N'CharField.
		public CharField PfMgdTable = new CharField('N');//88  PfMgdTableEndYes                VALUE 'Y'CharField.
		//88  PfMgdTableEndNo                 VALUE 'N'CharField.
		public CharField PfResTable = new CharField('N');//88  PfResTableEndYes                VALUE 'Y'CharField.
		//88  PfResTableEndNo                 VALUE 'N'CharField.
		public CharField PfPlanFound = new CharField('N');//88  PfPlanFoundYes                   VALUE 'Y'CharField.
		//88  PfPlanFoundNo                    VALUE 'N'CharField.
	}
}
