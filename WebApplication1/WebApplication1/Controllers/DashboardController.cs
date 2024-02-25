using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            ViewBag.v1 = c.Estates.Count().ToString();
			ViewBag.v2 = c.Estates.Where(x => x.AdvertiserID == adverid).Count().ToString();

			return View();
        }
    }
}
