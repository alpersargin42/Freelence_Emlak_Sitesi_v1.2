using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using ValidationResult = FluentValidation.Results.ValidationResult;


namespace WebApplication1.Controllers
{
    [AllowAnonymous]
	public class RegisterController : Controller
	{

		private AdvertiserManager ad = new AdvertiserManager(new EfAdvertiserRepository());
        private readonly PasswordHasher<Advertiser> _passwordHasher = new PasswordHasher<Advertiser>();
        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Index(Advertiser a)
        {
            AdvertiserValidator Ava = new AdvertiserValidator();
            ValidationResult results = Ava.Validate(a);
            if (results.IsValid)
            {
                a.AdvertiserStatus = true;
                a.AdvertiserAbout = "Emlak";

                // Hashleme işlemi
                a.AdvertiserPassword = HashPassword(a.AdvertiserPassword);
                a.AdvertiserPassword1 = HashPassword(a.AdvertiserPassword1);

                ad.AdvertiserAdd(a);
                return RedirectToAction("Index", "Estate");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

		private string HashPassword(string password)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// ComputeHash - returns byte array, convert byte array to a string
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

				// Convert byte array to a string
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
	}
}
