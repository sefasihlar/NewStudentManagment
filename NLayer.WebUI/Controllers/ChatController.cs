using Microsoft.AspNetCore.Mvc;

namespace NLayer.WebUI.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
