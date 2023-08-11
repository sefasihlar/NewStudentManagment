using Microsoft.AspNetCore.Mvc;

namespace NLayer.WebUI.ViewComponents
{
    public class ClassDetailViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
