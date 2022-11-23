using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	//88  Tracing                         VALUE 'Y'CharField.
	public class BeginWsType : Record
	{
		public StrField Filler1 = new StrField(21, "BEGIN WORKING STORAGE");
	}
}
