using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    public class AdminKullaniciController : Controller
    {
        EstateManager em = new EstateManager(new EfEstateRepository());
        AdvertiserManager ad = new AdvertiserManager(new EfAdvertiserRepository());
        public IActionResult Index()
        {
            var values = em.GetListWithCategory();
            return View(values);
        }
        public IActionResult DeleteEstate(int id)
        {
            var estatevalue = em.GetById(id);
            em.TDelete(estatevalue);
            return RedirectToAction("Index", "AdminKullanici");
        }
        [HttpGet]
        public IActionResult EditEstate(int id)
        {
            var estatevalue = em.GetById(id);
            return View(estatevalue);
        }
        [HttpPost]
        public IActionResult EditEstate(Estate a)
        {
            var estateToUpdate = em.GetById(a.EstateID); // Mevcut varlığı veritabanından al
            estateToUpdate.EstatePopu = a.EstatePopu; // Sadece EstatePopu alanını güncelle
            em.TUpdate(estateToUpdate); // Güncellenmiş varlığı veritabanına kaydet
            return RedirectToAction("Index", "AdminKullanici"); // Index'e yönlendir
        }
        public IActionResult Advertisers() 
        {
            var values = ad.GetList();
            return View(values); 
        }
        public IActionResult DeleteAdvertiser(int id)
        {
            var estatevalue = ad.GetById(id);
            ad.TDelete(estatevalue);
            return RedirectToAction("Advertisers", "AdminKullanici");
        }
    }
}
