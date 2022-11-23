using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalClasses;
namespace Records.BRDMVS
{
	//88 IcdGoLiveProcess     VALUE 'Y'CharField.
	public class AsZoneProcessParametersType : Record
	{
		public StrField AsZoneApplicationId = new StrField(4);//88  HospSystemValidations      VALUE "APAY" "GLED"
		//"GLZN"
		//"LTBD" "PACT"
		//"PAYR" "PSYC"
		//"QMIR" "RMRI"
		//"RMRO" "RPAK"
		//"ZONE"StrField.
		//88  ValidAppl                   VALUE "APAY" "DATE"
		//"DC01" "DC02"
		//"GLED" "GLZN"
		//"LTBD"
		//"PACT" "PAYR"
		//"PA01" "PA02"
		//"PSYC" "QMIR"
		//"RMRI" "RMRO"
		//"RPAK" "ZONE"
		//"ZN01" "ZN02"StrField.
		public StrField Filler66 = new StrField(571);
	}
}
