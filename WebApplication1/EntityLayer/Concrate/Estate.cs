using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Estate
    {
        [Key]
        public int EstateID { get; set; }
        public string EstateTitle { get; set; }
        public string EstateContent { get; set; }
        public string EstateNotes { get; set; }
        public string EstateImage { get; set; }
        public string EstateImage2 { get; set; }
        public string EstateImage3 { get; set; }
        public string EstateImage4 { get; set; }
        public string EstateImage5 { get; set; }
        public string EstateImage6 { get; set; }
        public string EstateImage7 { get; set; }
        public string EstateImage8 { get; set; }
        public string EstateImage9 { get; set; }
        public string EstateImage10 { get; set; }
        public bool EstatePopu { get; set; }
        public int EstatePrice { get; set; }
		public string EstateOzellik1 { get; set; }
		public string EstateOzellik2 { get; set; }
		public string EstateOzellik3 { get; set; }
		public string EstateOzellik4 { get; set; }
		public string EstateOzellik5 { get; set; }
		public string EstateOzellik6 { get; set; }
		public string EstateOzellik7 { get; set; }
		public string EstateOzellik8 { get; set; }
		public string EstateOzellik9 { get; set; }
		public string EstateOzellik10 { get; set; }
		public string EstateOzellik11 { get; set; }
		public string EstateOzellik12 { get; set; }
		public string EstateOzellik13 { get; set; }
		public string EstateOzellik14 { get; set; }
		public string EstateOzellik15 { get; set; }
        public DateTime EstateCreateDate { get; set;}
        public bool EstateStatus { get;set;}
        public int CategoryID { get;set;}
        public Category Category { get;set; }
        public List<Comment> Comments { get;set; }
        public Advertiser Advertiser { get; set; }
        public int AdvertiserID { get; set; }
    }
}
