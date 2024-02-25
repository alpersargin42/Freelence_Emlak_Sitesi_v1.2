using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class GoogleAuthOptions
	{
		public string ClientId { get; set; }
		public string ProjectId { get; set; }
		public string AuthUrl { get; set; }
		public string TokenUrl { get; set; }
		public string CertUrl { get; set; }
		public string ClientSecret { get; set; }
		public string RedirectUrl { get; set; }
	}
}
