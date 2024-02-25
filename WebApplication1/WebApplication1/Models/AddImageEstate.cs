﻿using EntityLayer.Concrate;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Models
{
    public class AddImageEstate
    {
        public int EstateID { get; set; }
        public string EstateTitle { get; set; }
        public string EstateContent { get; set; }
        public string EstateNotes { get; set; }
        public IFormFile EstateImage { get; set; }
        public IFormFile EstateImage2 { get; set; }
        public IFormFile EstateImage3 { get; set; }
        public IFormFile EstateImage4 { get; set; }
        public IFormFile EstateImage5 { get; set; }
        public IFormFile EstateImage6 { get; set; }
        public IFormFile EstateImage7 { get; set; }
        public IFormFile EstateImage8 { get; set; }
        public IFormFile EstateImage9 { get; set; }
        public IFormFile EstateImage10 { get; set; }
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
        public DateTime EstateCreateDate { get; set; }
        public bool EstateStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public Advertiser Advertiser { get; set; }
        public int AdvertiserID { get; set; }
    }
}