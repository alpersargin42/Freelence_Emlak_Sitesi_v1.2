using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class EstateRaytings
	{
		[Key]
		public int EstateRaytingID { get; set; }
		public int EstateID { get; set; }
		public int EstateTotalScore { get; set; }
		public int EstateReytingCount { get; set; }
	}
}
