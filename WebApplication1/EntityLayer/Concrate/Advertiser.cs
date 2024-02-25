using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Advertiser
    {
        [Key]
        public int AdvertiserID { get; set; }
        public string AdvertiserName { get; set; }
        public string AdvertiserAbout { get; set; }
        public string AdvertiserMail { get; set; }
        public string AdvertiserPassword { get; set; }
        public string AdvertiserPassword1 { get; set; }
        public bool AdvertiserStatus { get; set; }
        public List<Estate> Estates { get; set; }
        public virtual ICollection<Message2> AdvertiserSender { get; set; }
        public virtual ICollection<Message2> AdvertiserReceiver { get; set; }
    }
}
