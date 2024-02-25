using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents.Estate
{
    public class EstateListDashboard:ViewComponent
    {
       EstateManager pm = new EstateManager(new EfEstateRepository());

    public IViewComponentResult Invoke()
    {
        var values = pm.GetEstateListWithCategory();
        return View(values);
    } 
  }
}

