using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private AdvertiserManager ad = new AdvertiserManager(new EfAdvertiserRepository());

        public IActionResult Index()
        {
            return View();
        }

		//[HttpPost]
		//public async Task<IActionResult> Index(Advertiser model)
		//{
		//    Context c = new Context();
		//    var user = c.Advertisers.FirstOrDefault(x => x.AdvertiserMail == model.AdvertiserMail);

		//    if (user != null)
		//    {
		//        var passwordHasher = new PasswordHasher<Advertiser>();
		//        var result = passwordHasher.VerifyHashedPassword(user, user.AdvertiserPassword, model.AdvertiserPassword);

		//        if (result == PasswordVerificationResult.Success)
		//        {
		//            var claims = new[] { new Claim(ClaimTypes.Name, user.AdvertiserMail) };
		//            var identity = new ClaimsIdentity(claims, "login");
		//            var principal = new ClaimsPrincipal(identity);

		//            await HttpContext.SignInAsync(principal);
		//            return RedirectToAction("EstateListByAdvertiser", "Estate");
		//        }
		//    }

		//    // Yanlış giriş durumunda kullanıcıyı uyarmak için hata ekleyin
		//    ModelState.AddModelError(string.Empty, "Kullanıcı adı veya parola yanlış.");
		//    return View();
		//}
		[HttpPost]
		public async Task<IActionResult> Index(Advertiser model)
		{
			using (var sha256 = SHA256.Create())
			{
				Context c = new Context();
				var user = c.Advertisers.FirstOrDefault(x => x.AdvertiserMail == model.AdvertiserMail);

				if (user != null)
				{
					// Kullanıcının girdiği şifreyi hashleyin
					string hashedPasswordInput = HashPassword(model.AdvertiserPassword);

					// Veritabanındaki hashlenmiş şifre ile kullanıcının girdiği şifreyi karşılaştırın
					if (user.AdvertiserPassword == hashedPasswordInput)
					{
						if (user.AdvertiserMail == "adminheryeremlak2024@gmail.com")
						{
							return RedirectToAction("Index", "AdminKullanici");
						}
						else
						{
							var claims = new[] { new Claim(ClaimTypes.Name, user.AdvertiserMail) };
							var identity = new ClaimsIdentity(claims, "login");
							var principal = new ClaimsPrincipal(identity);

							// Kullanıcıyı kimliklendirin
							await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

							return RedirectToAction("EstateListByAdvertiser", "Estate");
						}
					}
				}
			}

			// Kullanıcı adı veya şifre yanlışsa
			ModelState.AddModelError(string.Empty, "Kullanıcı adı veya parola yanlış.");
			return View();
		}

		private string HashPassword(string password)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// Şifreyi hashleyin
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

				// Hashlenmiş şifreyi string olarak dönün
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}

		//    [HttpPost]
		//    [AllowAnonymous]
		//    [ValidateAntiForgeryToken]
		//    public IActionResult ExternalLogin(string provider, string returnUrl = null)
		//    {
		//        // Google ile giriş için dış yönlendirme başlatılıyor
		//        var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Login", new { returnUrl });
		//        var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
		//        return Challenge(properties, provider);
		//    }

		//    public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
		//    {
		//        Context _context = new Context();

		//        if (remoteError != null)
		//        {
		//            ModelState.AddModelError(string.Empty, $"Dış kaynaktan giriş hatası: {remoteError}");
		//            return RedirectToAction("Index", "Login");
		//        }

		//        // Google'dan gelen kullanıcı bilgileri alınıyor
		//        var info = await HttpContext.AuthenticateAsync("External");
		//        var email = info.Principal.FindFirstValue(ClaimTypes.Email);
		//        var firstName = info.Principal.FindFirstValue(ClaimTypes.GivenName);
		//        var lastName = info.Principal.FindFirstValue(ClaimTypes.Surname);

		//        // Kullanıcı veritabanında var mı kontrol ediliyor
		//        var existingUser = _context.Advertisers.FirstOrDefault(u => u.AdvertiserMail == email);

		//        if (existingUser == null)
		//        {
		//            // Kullanıcı yoksa veritabanına ekleniyor
		//            var newUser = new Advertiser
		//            {
		//                AdvertiserMail = email,
		//                AdvertiserName = firstName,
		//                AdvertiserStatus = true,
		//                AdvertiserAbout = "GMAİL"
		//                // Diğer kullanıcı bilgilerini burada ekleyebilirsiniz
		//            };

		//            _context.Advertisers.Add(newUser);
		//            await _context.SaveChangesAsync();
		//        }

		//        // Kullanıcıya ait işlemler yapıldıktan sonra giriş yapılıyor
		//        var claims = new List<Claim>
		//{
		//    new Claim(ClaimTypes.Email, email),
		//    // Diğer isteğe bağlı kullanıcı id bilgileri buraya eklenebilir
		//};

		//        var userIdentity = new ClaimsIdentity(claims, "login");
		//        var principal = new ClaimsPrincipal(userIdentity);
		//        await HttpContext.SignInAsync(principal);

		//        // Kullanıcının yönlendirilmesi
		//        if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
		//        {
		//            return Redirect(returnUrl);
		//        }
		//        else
		//        {
		//            return RedirectToAction("Index", "Home");
		//        }
		//    }


		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync();
			return RedirectToAction("Index", "Estate");
		}
	}
}
