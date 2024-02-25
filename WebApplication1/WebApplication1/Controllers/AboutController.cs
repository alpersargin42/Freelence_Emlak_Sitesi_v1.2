using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]

    public class AboutController : Controller
    {
		EstateManager em = new EstateManager(new EfEstateRepository());

		public IActionResult Index()
        {
			var values = em.GetListWithCategory();
			return View(values);
		}
    }
}
