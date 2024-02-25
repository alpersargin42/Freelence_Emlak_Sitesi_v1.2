using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication1.Controllers
{

    public class AdvertiserController : Controller
    {
        AdvertiserManager ad = new AdvertiserManager(new EfAdvertiserRepository());
        public IActionResult Index()
        {
            var username = User.Identity.Name;
            ViewBag.v = username;
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]

        public PartialViewResult AdvertiserNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]

        public PartialViewResult AdvertiserFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult AdvertiserEditProfile()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            var advertiservalues = ad.GetById(adverid);
            return View(advertiservalues);
        }
        [HttpPost]
        public IActionResult AdvertiserEditProfile(Advertiser a)
        {
            AdvertiserValidator validator = new AdvertiserValidator();
            ValidationResult result = validator.Validate(a);

            if (result.IsValid)
            {
                a.AdvertiserStatus = true;

                // Parolanın hashlenmiş versiyonunu oluştur
                a.AdvertiserPassword = HashPassword(a.AdvertiserPassword);
                a.AdvertiserPassword1 = HashPassword(a.AdvertiserPassword1);

                ad.TUpdate(a);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        // Parolayı hashleyen metot
        private string HashPassword(string password)
        {
            var passwordHasher = new PasswordHasher<Advertiser>();
            return passwordHasher.HashPassword(null, password);
        }
    }
}
