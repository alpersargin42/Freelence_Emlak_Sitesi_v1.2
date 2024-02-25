using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents.Advertiser
{
    public class AdvertiserNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
