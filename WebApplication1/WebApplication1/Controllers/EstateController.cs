using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EstateController : Controller
    {
        EstateManager em = new EstateManager(new EfEstateRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        [AllowAnonymous]

        public IActionResult Index()
        {
            var values = em.GetListWithCategory();
            return View(values);
        }
        [AllowAnonymous]

        public IActionResult EstateReadAll(int id)
        {
            ViewBag.i = id;
            var values = em.GetEstateByID(id);
            return View(values);
        }
        [AllowAnonymous]

        public IActionResult Kategorili(int id)
        {
            var values = em.GetEstateListWithCategory().Where(x => x.CategoryID == id).ToList();
            return View(values);
        }

        public IActionResult EstateListByAdvertiser()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            var values = em.GetListWithCategoryByAdvertiserEm(adverid);
            return View(values);
        }
        [HttpGet]
        public IActionResult EstateAdd()
        {
            //List<SelectListItem> categoryvalue = (from x in cm.GetList()
            //                                      select new SelectListItem
            //                                      {
            //                                          Text = x.CategoryName,
            //                                          Value = x.CategoryID.ToString()
            //                                      }).ToList();
            //ViewBag.cv = categoryvalue;
            return View();
        }
        [HttpPost]
        public IActionResult EstateAdd(Estate a, string EstateImageUrl, string EstateImageUrl2, string EstateImageUrl3, string EstateImageUrl4, string EstateImageUrl5,string EstateImageUrl6, string EstateImageUrl7, string EstateImageUrl8, string EstateImageUrl9,string EstateImageUrl10)
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            EstateValidator Ava = new EstateValidator();
            ValidationResult results = Ava.Validate(a);
            if (results.IsValid)
            {
                a.EstateStatus = true;
                a.EstateCreateDate = DateTime.Now;
                a.AdvertiserID = adverid;
                a.EstateImage = EstateImageUrl;
                a.EstateImage2 = EstateImageUrl2;
                a.EstateImage3 = EstateImageUrl3;
                a.EstateImage4 = EstateImageUrl4;
                a.EstateImage5 = EstateImageUrl5;
                a.EstateImage6= EstateImageUrl6;
                a.EstateImage7= EstateImageUrl7;
                a.EstateImage8= EstateImageUrl8;
                a.EstateImage9 = EstateImageUrl9;
                a.EstateImage10 = EstateImageUrl10;

                em.TAdd(a);
                return RedirectToAction("EstateListByAdvertiser", "Estate");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        [HttpPost]
        public IActionResult UploadAndCopyImage(IFormFile image, [FromServices] IWebHostEnvironment hostingEnvironment)
        {
            if (image != null && image.Length > 0)
            {
                var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "UploadFile");

                // Dosya adının başına tarih-saat ekleyin
                //var dateTimeNow = DateTime.Now.ToString("yyyyMMddHHmmss");
                var fileName = $"{image.FileName}";

                var filePath = Path.Combine(uploadPath, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }

                // Kopyalama işlemi başarıyla tamamlandı mesajını döndür
                return Ok("Resim başarıyla yüklendi ve kopyalandı.");
            }
            // Resim bulunamadı hatası döndür
            return BadRequest("Resim bulunamadı.");
        }

        public IActionResult DeleteEstate(int id)
        {
            var estatevalue = em.GetById(id);
            em.TDelete(estatevalue);
            return RedirectToAction("EstateListByAdvertiser", "Estate");
        }

        [HttpGet]
        public IActionResult EditEstate(int id)
        {
            var estatevalue = em.GetById(id);

            //List<SelectListItem> categoryvalue = (from x in cm.GetList()
            //                                      select new SelectListItem
            //                                      {
            //                                          Text = x.CategoryName,
            //                                          Value = x.CategoryID.ToString()
            //                                      }).ToList();
            //ViewBag.cv = categoryvalue;
            return View(estatevalue);
        }
        [HttpPost]
        public IActionResult EditEstate(Estate a)
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            var estatevalue = em.GetById(a.EstateID);
            a.EstateStatus = true;
            a.EstateCreateDate = DateTime.Now;
            a.AdvertiserID = adverid;
            //a.EstateImage = EstateImageUrl;
            //a.EstateImage2 = EstateImageUrl2;
            //a.EstateImage3 = EstateImageUrl3;
            //a.EstateImage4 = EstateImageUrl4;
            //a.EstateImage5 = EstateImageUrl5;
            em.TUpdate(a);
            return RedirectToAction("EstateListByAdvertiser");
        }
        [HttpGet]
        public IActionResult GetImagesFromDatabase()
        {
            Context c = new Context();
            // Veritabanından resim URL'lerini al
            var imageUrls = new List<string>();

            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage2).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage3).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage4).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage5).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage6).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage7).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage8).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage9).ToList());
            imageUrls.AddRange(c.Estates.Select(x => x.EstateImage10).ToList());


            return Json(imageUrls); // Resim URL'lerini JSON formatında dön
        }

    }
}
