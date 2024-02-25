using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    public class SearchController : Controller
    {
        private readonly Context _context; // Context sınıfını buraya dahil ediyoruz.

        public SearchController()
        {
            _context = new Context(); // Context sınıfının örneğini oluşturuyoruz.
        }
        [HttpPost]
        public IActionResult Search(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                var results = _context.Estates
                    .Where(e => e.EstateTitle.Contains(query))
                    .ToList();

                if (results.Any())
                {
                    return View(results);
                }
                else
                {
                    // Arama sorgusuyla ilgili sonuç bulunamadı
                    ViewBag.ErrorMessage = "No results found.";
                    return View();
                }
            }
            else
            {
                // Boş sorgu durumunda hata mesajı gösterelim
                ViewBag.ErrorMessage = "Please enter a search query.";
                return View();
            }
        }
    }
}
