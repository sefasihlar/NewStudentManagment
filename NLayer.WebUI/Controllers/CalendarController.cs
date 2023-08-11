using Microsoft.AspNetCore.Mvc;

namespace NLayer.WebUI.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
