using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager((new EfCommentRepository()));

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment c, int id)
        {
            c.CommentDate = DateTime.Now;
            c.CommentStatus = true;
            c.EstateID = id;
            cm.CommentAdd(c);

            // Yorum ekledikten sonra kullanıcıyı ilgili ilanın sayfasına yönlendirin.
            return RedirectToAction("EstateReadAll", "Estate", new { id = id });
        }
        public PartialViewResult CommentListByEstate(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
