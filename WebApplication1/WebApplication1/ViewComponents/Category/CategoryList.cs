using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private EstateManager pm = new EstateManager(new EfEstateRepository());


        public IViewComponentResult Invoke()
        {
            EntityLayer.Concrate.Category c = new EntityLayer.Concrate.Category();
            var values = cm.GetList();
            ViewBag.v = pm.GetList().Count();
            return View(values);
        }
    }
}
