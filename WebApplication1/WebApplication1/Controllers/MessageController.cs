using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InBox()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            var values = mm.GetInboxListByAdvertiser(adverid);
            return View(values);
        }
        public IActionResult SendBox()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            var values = mm.GetSendboxListWithMessageByAdvertiser(adverid);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = mm.GetById(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult SendMessage(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 p,int id)
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Advertisers.Where(x => x.AdvertiserMail == username).Select(y => y.AdvertiserMail).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();
            p.SenderID = adverid;
            ViewBag.id = id;
            p.ReceiverID = ViewBag.id;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("SendBox");
        }
    }
}
