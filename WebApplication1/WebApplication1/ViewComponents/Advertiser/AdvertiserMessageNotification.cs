using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication1.ViewComponents.Advertiser
{
    public class AdvertiserMessageNotification:ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            var values = mm.GetInboxListByAdvertiser(adverid);
            return View(values);
        }
    }
}
