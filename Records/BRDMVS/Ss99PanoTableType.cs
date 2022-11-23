using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	public class Ss99PanoTableType : Record
	{
		public LongField[] PanoEntry = (from occurs in Enumerable.Range(1, 01000) select new LongField(12)).ToArray();
	}
}
