using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Concreate;
using NLayer.WebUI.Models;
using System.Diagnostics;

namespace NLayer.WebUI.Controllers
{
   

    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            this.userManager=userManager;
            _httpContextAccessor=httpContextAccessor;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            var ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();

            // X-Forwarded-For başlığını kontrol et
            var xForwardedForHeader = _httpContextAccessor.HttpContext.Request.Headers["X-Forwarded-For"];
            if (!string.IsNullOrEmpty(xForwardedForHeader))
            {
                ipAddress = xForwardedForHeader.FirstOrDefault();
            }

            if (string.IsNullOrEmpty(ipAddress))
            {
                ipAddress = "IP adresi bulunamadı.";
            }

            // IP adresini ViewBag üzerinden view'a gönderelim
            ViewBag.IPAddress = ipAddress;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}