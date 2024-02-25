using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
